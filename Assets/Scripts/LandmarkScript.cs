using System;
using UnityEngine;

public class LandmarkScript : MonoBehaviour
{
    private Animator animator;
    private GameObject player;
    public TextMesh textMesh;
    private string LocationName;
    public float distance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.localScale *=0.1f;
        player = GameObject.Find("Main Camera");
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateDist();
        if (animator != null)
        {
            if (distance<=3f)
            {
                animator.SetTrigger("Close");
            }
            else
            {
                animator.SetTrigger("Far");
            }
            //Debug.Log("WorkingAnimator Attached");
        }
        else
        {
            //Debug.Log("Animator NOt Working");
        }
    }

    public void AssignLocation(string location)
    {
        LocationName=location;
        textMesh.text = LocationName;
    }

    void UpdateDist()
    {
        distance = Vector3.Distance(transform.position, player.transform.position);
    }
}
