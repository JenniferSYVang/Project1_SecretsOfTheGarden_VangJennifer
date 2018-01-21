using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowChest : MonoBehaviour {
    [SerializeField]
    private GameObject player;

    [SerializeField]
    private GameObject chest;

    [SerializeField]
    private GameObject chestlid;

    // Use this for initialization
    void Start () {
        chest.GetComponent<MeshRenderer>().enabled = false;
        chest.GetComponent<MeshCollider>().enabled = false;

        chestlid.GetComponent<MeshRenderer>().enabled = false;
        chestlid.GetComponent<MeshCollider>().enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
		if(player.transform.position.y <= 5)
        {
            chest.GetComponent<MeshRenderer>().enabled = true;
            chest.GetComponent<MeshCollider>().enabled = true;

            chestlid.GetComponent<MeshRenderer>().enabled = true;
            chestlid.GetComponent<MeshCollider>().enabled = true;
        }
	}
}
