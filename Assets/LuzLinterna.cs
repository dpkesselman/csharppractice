using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuzLinterna : MonoBehaviour
{
    public Light luzLinterna;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (luzLinterna.enabled == true)
            {
                luzLinterna.enabled = false;
            }

            else if (luzLinterna.enabled == false)
            {
                luzLinterna.enabled = true;
            }
        }
    }
}
