using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpPrompt : MonoBehaviour
{
    public static bool isOpen = false;
    public GameObject helpMenuUI;

    public void Close()
    {
        helpMenuUI.SetActive(false);
        isOpen = false;
    }

    public void Open()
    {
        helpMenuUI.SetActive(true);
        isOpen = true;
    }
    
    public void Button()
    {
        if (isOpen)
        {
            Close();
        }
        else
        {
            Open();
        }
    }
}
