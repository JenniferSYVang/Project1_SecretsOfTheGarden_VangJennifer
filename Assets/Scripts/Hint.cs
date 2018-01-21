using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hint : MonoBehaviour {
    [SerializeField]
    private GameObject pickUp;

    [SerializeField]
    private Text messageDisplay;

    private bool foundPU = false;

    private void OnTriggerEnter()
    {
        if (pickUp.GetComponent<MeshRenderer>().enabled == true)
        {
            messageDisplay.text = "It's somewhere around here...";

        }
        else if(pickUp.GetComponent<MeshRenderer>().enabled == false)
        {
            this.GetComponent<MeshCollider>().enabled = false;
        }
    }

    private void OnTriggerExit()
    {
        if (pickUp.GetComponent<MeshCollider>().enabled == true)
        {
            messageDisplay.text = "I need to go back and find that button.";
        }
    }
}
