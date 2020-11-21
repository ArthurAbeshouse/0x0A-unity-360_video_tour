using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Display_info : MonoBehaviour
{
    private bool display = false;
    public void Info()
    {
        if (display == false)
        {
            gameObject.SetActive(true);
            display = true;
        }
        else
        {
            gameObject.SetActive(false);
            display = false;
        }
    }
}
