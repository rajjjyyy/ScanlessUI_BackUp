using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnvironmentToCameraOrientation : MonoBehaviour
{
    [SerializeField] private string FromStr;
    [SerializeField] private string ToStr;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private GameObject environmentPrefab;

    private Vector3 newPosition;
    private float newRotation;
    private bool isFalse;
    private DictionaryClass dictionary;

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

    private void OnEnable()
    {
        isFalse=false;
        dictionary = new DictionaryClass();
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Displacement();
    }

    void Start()
    {
        /*isFalse=false;
        dictionary = new DictionaryClass();
        Displacement();*/
    }
    // Update is called once per frame
    void Update()
    {

    }

    void Displacement()
    {
        if(File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            NavigateData navigate = JsonUtility.FromJson<NavigateData>(json);
            FromStr = navigate.initial_position;
            ToStr = navigate.destination_position;
            Debug.Log("From: " + FromStr+"\nTo: " + ToStr);
            if (dictionary.environmentDisplacement.Count > 0 && isFalse == false) 
            {
                //Takes Vector3 Values from String keys
                newPosition = dictionary.environmentDisplacement[CleanKey(FromStr.ToString())][0];
                newRotation = dictionary.environmentDisplacement[CleanKey(FromStr.ToString())][1].x;
                //Transforms position of reference objects
                if (environmentPrefab != null)//IndoorNav.player != null
                environmentPrefab.transform.position = (newPosition*(-1));
                AllignRoomWithCamera(newRotation);

                Debug.Log("Moved player and target after prefab loaded.");
                isFalse=true;
                Debug.Log("isFalse boolean value is now true");
            }
        }
        
    }

    void AllignRoomWithCamera(float Rotation)
    {
        environmentPrefab.transform.RotateAround(Vector3.zero,Vector3.up,Rotation);
    }

    string CleanKey(string s)
    {
    return new string(s
        .Where(c => !char.IsControl(c) && c != '\u200b' && c != '\uFEFF')
        .ToArray())
        .Trim();
    }
}
