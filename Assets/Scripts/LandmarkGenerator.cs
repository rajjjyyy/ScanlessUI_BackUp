using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class LandmarkGenerator : MonoBehaviour
{
    //[SerializeField] private TargetAndEnvironmentScript dictionary;
    private DictionaryClass dictionary;
    [SerializeField] private GameObject Target;
    [SerializeField] private GameObject LandmarkPrefab;
    private LandmarkScript landmarkScript;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //dictionary = new DictionaryClass();
    }
    private void OnEnable()
    {
        dictionary = new DictionaryClass();
        TargetAndEnvironmentScript.AddLandmark+=AddLandmark;
    }
    private void OnDisable()
    {
        TargetAndEnvironmentScript.AddLandmark-=AddLandmark;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void AddLandmark()
    {
        foreach(KeyValuePair<string, Vector3> item in dictionary.destinationPoint)
        {
            if(item.Value != Target.transform.position)
            {
            GameObject Landmark = GameObject.Instantiate(LandmarkPrefab,item.Value,Quaternion.identity);
            Landmark.transform.SetParent(transform.parent);
            Landmark.transform.localPosition = item.Value;
            Landmark.transform.localEulerAngles = Vector3.zero;
            landmarkScript = Landmark.GetComponent<LandmarkScript>();
            landmarkScript.AssignLocation(item.Key);
            }
        }

    }
}
