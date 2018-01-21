using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnOpnDoor : MonoBehaviour {

    public void OpenRightDoor()
    {
        this.transform.Rotate(0, -115, 0);

    }


    public void OpenLeftDoor()
    {
        this.transform.Rotate(0, 115, 0);
    }
}
