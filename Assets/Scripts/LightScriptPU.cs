using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScriptPU : MonoBehaviour {
    [SerializeField]
    private GameObject player;

    [SerializeField]
    private GameObject pickUp;

    [SerializeField]
    private GameObject light;

    private Behaviour halo;

    private void Start()
    {
        halo = (Behaviour) light.GetComponent("Halo");
        halo.enabled = false;  
    }

    // Update is called once per frame
    private void OnTriggerEnter (Collider other) {
        if(pickUp.GetComponent<MeshRenderer>().enabled == true)
            halo.enabled = true;
    }

    private void OnTriggerExit(Collider other)
    {
        halo.enabled = false;
    }
}
