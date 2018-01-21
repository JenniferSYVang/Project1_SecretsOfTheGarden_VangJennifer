using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block4LightUp : MonoBehaviour {
    [SerializeField]
    private GameObject hedge1;

    [SerializeField]
    private BlockLightUp first;

    [SerializeField]
    private Block2LightUp second;

    [SerializeField]
    private Block3LightUPHard third;


    public void OnMouseDown()
    {
        if (first.clicked == true && second.clicked2 == true && third.clicked3 == true)
        {
            this.GetComponent<Renderer>().material.shader = Shader.Find("Self-Illumin/Outlined Diffuse");
            hedge1.GetComponent<MeshCollider>().enabled = false;
            hedge1.GetComponent<MeshRenderer>().enabled = false;

        }
        else
        {
            first.GetComponent<Renderer>().material.shader = Shader.Find("Diffuse");
            first.clicked = false;

            second.GetComponent<Renderer>().material.shader = Shader.Find("Diffuse");
            second.clicked2 = false;

            third.GetComponent<Renderer>().material.shader = Shader.Find("Diffuse");
            third.clicked3 = false;
        }
    }
}
