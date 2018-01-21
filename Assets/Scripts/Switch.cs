using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour {
    [SerializeField]
    private GameObject hedge1;

    [SerializeField]
    private GameObject hedge2;

	private void OnMouseDown()
    {
        this.transform.Rotate(0, 0, -30);
        hedge1.GetComponent<MeshCollider>().enabled = false;
        hedge1.GetComponent<MeshRenderer>().enabled = false;

        hedge2.GetComponent<MeshCollider>().enabled = false;
        hedge2.GetComponent<MeshRenderer>().enabled = false;
    }
}
