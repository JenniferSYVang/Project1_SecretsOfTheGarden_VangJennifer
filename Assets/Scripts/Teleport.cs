using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {
    [SerializeField]
    private GameObject player;
	private void OnMouseDown()
    {
        player.transform.position = new Vector3(31, 11, 35);
    }
}
