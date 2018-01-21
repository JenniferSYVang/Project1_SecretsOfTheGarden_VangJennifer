using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour {
    [SerializeField]
    private Canvas options;

    [SerializeField]
    private Canvas tryCanvas;

    private float secTimer = 60;
    private bool start = false;

    private void Update()
    {
        secTimer -= Time.deltaTime;

        if (secTimer > 0 && start)
        {
            options.enabled = false;
            tryCanvas.enabled = true;
        }
        else if(secTimer <= 0 && start)
        {
            options.enabled = true;
            tryCanvas.enabled = false;
            secTimer = 10;
            start = false;
        }
    }

    public void startTimer()
    {
        start = true;
    }
}
