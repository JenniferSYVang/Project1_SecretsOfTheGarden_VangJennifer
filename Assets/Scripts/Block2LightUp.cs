using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block2LightUp : MonoBehaviour {
    [SerializeField]
    private BlockLightUp firstBlock;

    public bool clicked2 = false;

	private void OnMouseDown()
    {
        if (firstBlock.clicked == true)
        {
            clicked2 = true;
            this.GetComponent<Renderer>().material.shader = Shader.Find("Self-Illumin/Outlined Diffuse");
        }
        else
        {
            firstBlock.clicked = false;
            firstBlock.GetComponent<Renderer>().material.shader = Shader.Find("Diffuse");
        }
        
    }
}
