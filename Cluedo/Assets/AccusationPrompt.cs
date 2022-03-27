using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccusationPrompt : MonoBehaviour
{
    public static bool IsOpen = false;
    public GameObject accusationUI;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
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
        accusationUI.SetActive(false);
        IsOpen = false;
    }

    public void Open()
    {
        accusationUI.SetActive(true);
        IsOpen = true;
    }
}
