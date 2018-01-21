using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EasyPUScore : MonoBehaviour {
    [SerializeField]
    private Text countTxt;

    [SerializeField]
    private GameObject light;


    private Behaviour halo;
    private int count = 0;

    private void OnTriggerEnter(Collider other)
    {
        halo = (Behaviour)light.GetComponent("Halo");
        halo.enabled = false;        

        this.GetComponent<MeshCollider>().enabled = false;
        this.GetComponent<MeshRenderer>().enabled = false;

        count = int.Parse(countTxt.text);
        count += 1;
        countTxt.text = count.ToString();
    }
}
