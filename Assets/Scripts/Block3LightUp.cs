using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block3LightUp : MonoBehaviour {
    [SerializeField]
    private GameObject hedge1;

    [SerializeField]
    private GameObject hedge2;

    [SerializeField]
    private BlockLightUp first;

    [SerializeField]
    private Block2LightUp second;


    public void OnMouseDown()
    {
        if (first.clicked == true && second.clicked2 == true)
        {

            hedge1.GetComponent<MeshCollider>().enabled = false;
            hedge1.GetComponent<MeshRenderer>().enabled = false;

            hedge2.GetComponent<MeshCollider>().enabled = false;
            hedge2.GetComponent<MeshRenderer>().enabled = false;

        }
        else
        {
            first.GetComponent<Renderer>().material.shader = Shader.Find("Diffuse");
            second.GetComponent<Renderer>().material.shader = Shader.Find("Diffuse");
        }
    }
}
