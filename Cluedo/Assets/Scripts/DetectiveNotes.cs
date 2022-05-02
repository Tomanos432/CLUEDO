using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectiveNotes : MonoBehaviour
{

    public static bool IsOpen = false;
    public GameObject Notepad;

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.N))
        {
            if (IsOpen)
            {
                Close();
            }
            else
            {
                Open();
            }
        }
    }

    public void Close()
    {
        Notepad.SetActive(false);
        IsOpen = false;
    }

    public void Open()
    {
        Notepad.SetActive(true);
        IsOpen = true;
    }
    
    public void Button()
    {
        if (IsOpen)
        {
            Close();
        }
        else
        {
            Open();
        }
    }
}
