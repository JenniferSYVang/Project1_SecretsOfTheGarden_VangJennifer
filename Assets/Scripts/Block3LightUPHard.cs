using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block3LightUPHard : MonoBehaviour {

    [SerializeField]
    private BlockLightUp first;

    [SerializeField]
    private Block2LightUp second;

    public bool clicked3 = false;

    public void OnMouseDown()
    {
        if (first.clicked && second.clicked2)
        {
            this.GetComponent<Renderer>().material.shader = Shader.Find("Self-Illumin/Outlined Diffuse");
            clicked3 = true;
        }
        else
        {
            first.GetComponent<Renderer>().material.shader = Shader.Find("Diffuse");
            second.GetComponent<Renderer>().material.shader = Shader.Find("Diffuse");
        }
    }
}
