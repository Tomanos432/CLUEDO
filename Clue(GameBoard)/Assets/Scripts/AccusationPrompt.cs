using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccusationPrompt : MonoBehaviour
{
    public static bool IsOpen = false;
    public GameObject accusationUI;
    
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
