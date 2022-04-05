using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    
    
    public bool hasBall;

    private void Start()
    {
        hasBall = false;
        
    }

    private void Update()
    {
        if (hasBall == false)
        {
            GetComponent<BallSpawner>().enabled = true;
        }
        else
        {
            GetComponent<BallSpawner>().enabled = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            hasBall = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            hasBall = false;
        }
    }

    private void OnMouseEnter()
    {
        GetComponent<Renderer>().material.color = Color.yellow;
    }

    private void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = Color.grey;
    }
}
