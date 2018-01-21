using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeSwitch : MonoBehaviour {
    [SerializeField]
    private GameObject bridge;

    private bool pressed = false;

    private void OnMouseDown()
    {
        if(!pressed)
        {
            this.transform.Rotate(0, 0, -25);
            bridge.GetComponent<MeshCollider>().enabled = true;
            bridge.GetComponent<MeshRenderer>().enabled = true;
            pressed = true;
        }
        
    }
}
