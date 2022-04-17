using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quitApp : MonoBehaviour
{
    public void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Escape) == true)
        {
            Application.Quit();
        }
    }
}
