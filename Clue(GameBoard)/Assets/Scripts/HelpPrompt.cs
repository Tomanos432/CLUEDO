using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpPrompt : MonoBehaviour
{
    public static bool isOpen = false;
    public GameObject helpMenuUI;
    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.H))
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
}
