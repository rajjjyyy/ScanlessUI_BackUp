using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NavigationUIScript : MonoBehaviour
{
    [SerializeField] private TMP_InputField from;
    [SerializeField] private TMP_InputField to;
    [SerializeField] private TMP_Text fromInit;
    [SerializeField] private TMP_Text toInit;
    [SerializeField] private GameObject UpdatedPanel;
    [SerializeField] private GameObject RejectPanel;
    [SerializeField] private GameObject NavCanvas;
    [SerializeField] private GameObject InitiateCanvas;
    [SerializeField] private GameObject StartCanvas;
    private string resourcePath;
    private string filePath;
    //public static NavigationUIScript navScrpt;

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

    void Start()
    {
        NavCanvas.SetActive(true);
        InitiateCanvas.SetActive(false);
        StartCanvas.SetActive(false);
        if(File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            NavigateData navigate = JsonUtility.FromJson<NavigateData>(json);
            from.text = navigate.initial_position;
            to.text = navigate.destination_position;
            fromInit.text = navigate.initial_position;
            toInit.text = navigate.destination_position;
        }
        else
        {
            RejectPanel.SetActive(true);
        }
        
       /* if (navScrpt == null)
        {
            navScrpt = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }*/
    }

    [System.Serializable]
    public class NavigateData
    {
        public string initial_position;
        public string destination_position;
    }

    public void UpdtJSON()
    {
        if(from.text!=to.text)
        {
            Debug.Log("Works Updating JSON");
            //Update JSON file through here
            NavigateData navigateData= new NavigateData{
                initial_position = from.text.Trim().Replace("\n", "").Replace("\r", ""),
                destination_position = to.text.Trim().Replace("\n", "").Replace("\r", "")
            };
            string updateJson = JsonUtility.ToJson(navigateData, true);
            Debug.Log(updateJson);
            File.WriteAllText(filePath, updateJson);
            UpdatedPanel.SetActive(true);
        }
        else
        {
            RejectPanel.SetActive(true);
        }
    }
    public void ClosePanel()
    {
        UpdatedPanel.SetActive(false);
        fromInit.text = from.text.Trim();
        toInit.text = to.text.Trim();
    }
    public void CloseReject()
    {
        RejectPanel.SetActive(false);
    }
    
    public void NavCanvasToInitiateCanvas()
    {
        NavCanvas.SetActive(false);
        InitiateCanvas.SetActive(true);
        StartCanvas.SetActive(false);
        //NavigateData navigate = JsonUtility.FromJson<NavigateData>(textfile.ToString());
    }

    public void InitiateCanvasToStartCanvas()
    {
        NavCanvas.SetActive(false);
        InitiateCanvas.SetActive(false);
        StartCanvas.SetActive(true);
    }
    public void InitiateCanvasToNavCanvas()
    {
        NavCanvas.SetActive(true);
        InitiateCanvas.SetActive(false);
        StartCanvas.SetActive(false);
    }

    public void SwitchScene()
    {
        GlobalEventScript.TriggerEvent();
        SceneManager.LoadScene(1);
    }
}
