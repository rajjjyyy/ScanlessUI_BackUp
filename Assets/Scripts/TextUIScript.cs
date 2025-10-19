using TMPro;
using Unity.AI.Navigation;
using UnityEngine.AI;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class TextUIScript : MonoBehaviour
{
    [SerializeField] private TMP_Text Distance;
    [SerializeField] private TMP_Text SourceToDestination;
    [SerializeField] private GameObject ArrivedPanel;
    [SerializeField] private CameraToTarget pathmaker;
    
    private float dist;
    private string From;
    private string To;

    private string resourcePath;
    private string filePath;

    [System.Serializable]
    public class NavigateData
    {
        public string initial_position;
        public string destination_position;
    }

    void Awake()
    {
        // Set up the paths
        resourcePath = Path.Combine(Application.streamingAssetsPath, "JSON/Navigate.json");
        filePath = Path.Combine(Application.persistentDataPath, "Navigate.json");
        
        // Ensure the JSON file exists in persistent path
        if (!File.Exists(filePath) && File.Exists(resourcePath))
        {
            File.Copy(resourcePath, filePath);
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*dist = 0;
        NavigateData navigate = JsonUtility.FromJson<NavigateData>(textfile.ToString());
        From = navigate.initial_position;
        To = navigate.destination_position;
        SourceToDestination.text = From.ToString() +" >>> "+ To.ToString();*/
    }

    private void OnEnable()
    {
        exists  = false;
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        TextChanges();
    }

    private void TextChanges()
    {
        if(File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            NavigateData navigate = JsonUtility.FromJson<NavigateData>(json);
            From = navigate.initial_position;
            To = navigate.destination_position;
            Debug.Log("From: " + From+"\nTo: " + To);
            SourceToDestination.text = From.ToString() +" >>> "+ To.ToString();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        dist = GetPathLength(pathmaker.navMeshPath);
        if (exists)
        {
            Distance.text = dist.ToString("F0")+"m";
        }
        else
        {
            Distance.text = "No Path Detected";
        }
        if(dist<0.9f&&dist!=0)
        {
            ArrivedPanel.SetActive(true);
        }
        
    }
    private bool exists;
    float GetPathLength(NavMeshPath path)
    {
        float total = 0f;
        if(path != null)
        { 
            if (path.corners.Length < 2) return total;
            for (int i = 0; i < path.corners.Length - 1; i++)
            {
                total += Vector3.Distance(path.corners[i], path.corners[i + 1]);
            }
            exists = true;
        }
        else
        {
            exists = false;
        }
        return total;
    }

    public void ExitARButton()
    {
        Debug.Log("Exit Button Works");
        //SceneManager.LoadScene(0);
        Application.Quit();
    }

    public void ArrivedDestinationButton()
    {
        Debug.Log("Panel Button Works");
        ArrivedPanel.SetActive(false);
        Application.Quit();
    }
}
