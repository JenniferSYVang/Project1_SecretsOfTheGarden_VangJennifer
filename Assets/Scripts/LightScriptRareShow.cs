using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScriptRareShow : MonoBehaviour {
    [SerializeField]
    private GameObject player;

    [SerializeField]
    private GameObject light;

    [SerializeField]
    private GameObject lid;

    private Behaviour halo;


    private void Start()
    {
        halo = (Behaviour)light.GetComponent("Halo");
        halo.enabled = false;
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if(lid.GetComponent<MeshRenderer>().enabled == true)
        {
            halo.enabled = true;
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        halo.enabled = false;
    }
}
