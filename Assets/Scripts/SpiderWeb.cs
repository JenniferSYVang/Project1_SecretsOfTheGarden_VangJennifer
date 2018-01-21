using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderWeb : MonoBehaviour {

	void OnMouseDown()
    {
        this.GetComponent<MeshRenderer>().enabled = false;
        this.GetComponent<MeshCollider>().enabled = false;
    }
}
