using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockLightUp : MonoBehaviour {
    public bool clicked = false;

    private void OnMouseDown()
    {
        clicked = true;
        this.GetComponent<Renderer>().material.shader = Shader.Find("Self-Illumin/Outlined Diffuse");
    }

    private void OnMouseUp()
    {

    }
}
