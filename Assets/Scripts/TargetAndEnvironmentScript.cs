using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;
using System;
using System.Linq;
using UnityEngine.SceneManagement;
using System.IO;



public class TargetAndEnvironmentScript : MonoBehaviour
{
    /*
    FromStr - String from the JSON file Navigation.json to mark which where the initial position of the Camera will be
    ToStr - String from the JSON file Navigation.json to mark which where the destination position of the Target object
    Xnum, Ynum, Znum - Offset float values, Prefab Target object uses its Vectors from within the prefab while Player Object (Camera) uses Global Vector coordinates
                       New position of camera will be offset to match prefab initial position. -Cannot be changed due to ARTrackedImage UpdateImage property
    maplocation - is a Dictionary used with string keys and Vector3 values to instantly get Corrdinate position
    newPos - new position of Camera
    newTarget - new position of Target object
    playerObject - reference to playerObject for transformation purposes
    IndoorNav - References script for subscription of events. used as a buffer as to not conflict the sequence generating prefabs then transforming player and camera objects
    textfile - References Navigation.json 
    NavigateData - is a Class to extract string values from the Json file
    */
    [SerializeField] private string FromStr;
    [SerializeField] private string ToStr;
    public static event System.Action AddLandmark;
    private bool isFalse;
    private DictionaryClass dictionary;

    private string resourcePath;
    private string filePath;

    //Define Dictionary with a string as a key and Vector3 as a value
    //Experimenting with serializeField to try and store add immediately to code
    //[SerializeField] public Dictionary<string, Vector3> mapLocation = new Dictionary<string, Vector3>();
    [SerializeField] private Vector3 newPos;
    [SerializeField] private Vector3 newTarget;
    [SerializeField] private GameObject targetObject;
    [SerializeField] private TextMesh textMesh;

    [System.Serializable]
    public class NavigateData
    {
        public string initial_position;
        public string destination_position;
    }
    //Subscribe public event from newIndoorNav script
   
    //Perform upon initialization of unity
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
        isFalse = false;
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

    //Co-routine method - Upon recieving detecting an InitiateMove() from reference script, uses coroutine to skip a frame and ensure the buffer delay goes well
    void Displacement()
    {
        if(File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            NavigateData navigate = JsonUtility.FromJson<NavigateData>(json);
            FromStr = navigate.initial_position;
            ToStr = navigate.destination_position;
            Debug.Log("From: " + FromStr+"\nTo: " + ToStr);
            if (dictionary.destinationPoint.Count > 0 && isFalse == false) 
            {
                //Takes Vector3 Values from String keys
                newTarget = dictionary.destinationPoint[CleanKey(ToStr.ToString())];
                //Transforms position of reference objects
                if (targetObject != null)
                    targetObject.transform.localPosition = newTarget;
                    textMesh.text = ToStr.ToString();

                Debug.Log("Moved player and target after prefab loaded.");
                isFalse=true;
                Debug.Log("isFalse boolean value is now true");
                AddLandmark?.Invoke();
                Debug.Log("Add Landmark signal sent");
            }
        }
        
    }

    public Vector3 getToVCT3()
    {
        return newTarget;
    }

    public Vector3 getFrom()
    {
        return newPos;
    }
    string CleanKey(string s)
    {
    return new string(s
        .Where(c => !char.IsControl(c) && c != '\u200b' && c != '\uFEFF')
        .ToArray())
        .Trim();
    }
    
}
