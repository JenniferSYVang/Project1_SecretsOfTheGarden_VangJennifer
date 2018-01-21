using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToFar : MonoBehaviour {
    [SerializeField]
    private Text messageDisplay;

    private void OnTriggerExit()
    {
        messageDisplay.text = "";
    }

}
