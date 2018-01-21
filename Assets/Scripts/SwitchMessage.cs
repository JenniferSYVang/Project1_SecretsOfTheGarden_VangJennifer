using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchMessage : MonoBehaviour {
    [SerializeField]
    private Text messageDisplay;

    [SerializeField]
    private GameObject pickUp;

    [SerializeField]
    private GameObject player;

    private void OnTriggerEnter()
    {
        if (pickUp.GetComponent<MeshCollider>().enabled == true)
        {
            messageDisplay.text = "I see something shiny over there.";

        }
        else if (pickUp.GetComponent<MeshRenderer>().enabled == false)
        {
            this.GetComponent<MeshCollider>().enabled = false;
        }
    }

    private void OnTriggerExit()
    {
        messageDisplay.text = "";
    }
}
