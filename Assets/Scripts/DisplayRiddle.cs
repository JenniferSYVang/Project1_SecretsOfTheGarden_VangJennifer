using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayRiddle : MonoBehaviour {
    [SerializeField]
    private GameObject hedge1;

    private bool correctA = false;
    public bool triggered = false;

    void FixedUpdate()
    {
        if (triggered && !correctA)
        {
            this.GetComponent<Canvas>().enabled = true;
        }
        else// if(triggered && correctA)
        {
            this.GetComponent<Canvas>().enabled = false;
        }
            
    }

    public void CorrectAnswer()
    {
        hedge1.GetComponent<MeshRenderer>().enabled = false;
        hedge1.GetComponent<MeshCollider>().enabled = false;
        correctA = true;
        this.GetComponent<Canvas>().enabled = false;
        
    }
}
