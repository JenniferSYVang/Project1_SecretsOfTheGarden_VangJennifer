
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickupAndRecord : MonoBehaviour {
    [SerializeField]
    private Text countTxt;

    [SerializeField]
    private GameObject lid;

    [SerializeField]
    private GameObject light;

    private Behaviour halo;

    private int count = 0;

	private void OnTriggerEnter(Collider other)
    {
        this.GetComponent<MeshCollider>().enabled = false;
        this.GetComponent<MeshRenderer>().enabled = false;
        lid.GetComponent<MeshCollider>().enabled = false;
        lid.GetComponent<MeshRenderer>().enabled = false;
        halo = (Behaviour)light.GetComponent("Halo");
        halo.enabled = false;

        count = int.Parse(countTxt.text);
        count += 1;
        countTxt.text = count.ToString();
    }
}
