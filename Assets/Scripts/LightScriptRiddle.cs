using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScriptRiddle : MonoBehaviour
{
    [SerializeField]
    private GameObject player;

    [SerializeField]
    private GameObject light;
    private Behaviour halo;

    public DisplayRiddle ridCanvas;
    private void Start()
    {
        halo = (Behaviour)light.GetComponent("Halo");
        halo.enabled = false;

    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        halo.enabled = true;
        ridCanvas.triggered = true;

    }

    private void OnTriggerExit(Collider other)
    {
        halo.enabled = false;
        ridCanvas.triggered = false;
    }

}
