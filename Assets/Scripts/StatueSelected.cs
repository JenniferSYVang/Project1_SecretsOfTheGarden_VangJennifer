using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class StatueSelected : MonoBehaviour{
    [SerializeField]
    private GameObject hedge1;

    [SerializeField]
    private GameObject hedge2;

    void OnMouseDown()
    {
        hedge1.GetComponent<MeshRenderer>().enabled = false;
        hedge2.GetComponent<MeshRenderer>().enabled = false;
        hedge1.GetComponent<MeshCollider>().enabled = false;
        hedge2.GetComponent<MeshCollider>().enabled = false;
    }
}
