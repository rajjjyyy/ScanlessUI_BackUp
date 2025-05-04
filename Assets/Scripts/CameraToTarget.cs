using System.Collections.Generic;
using System.Linq;
using Unity.AI.Navigation;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.XR.ARFoundation;

public class CameraToTarget : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform target;
    [SerializeField] private GameObject environment;
    [SerializeField] private LineRenderer line;

    private NavMeshSurface navMeshSurface;
    public NavMeshPath navMeshPath;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        navMeshSurface =  environment.transform.GetComponentInChildren<NavMeshSurface>();
        navMeshPath = new NavMeshPath();
        //navMeshSurface.BuildNavMesh();
    }

    // Update is called once per frame
    void Update()
    {
        if(target != null&& navMeshPath != null)
        {
            NavMesh.CalculatePath(player.position, target.transform.position, NavMesh.AllAreas, navMeshPath);
            if (navMeshPath.status == NavMeshPathStatus.PathComplete) {
                line.positionCount = navMeshPath.corners.Length;
                line.SetPositions(navMeshPath.corners);
            } else {
                line.positionCount = 0;
            }
        }
    }
}
