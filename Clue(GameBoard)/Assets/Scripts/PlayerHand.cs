using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHand : MonoBehaviour
{
	public static bool IsOpen = false;

	public GameObject playerHandUI;
    
    public void Close()
    {
        playerHandUI.SetActive(false);
        IsOpen = false;
    }
   
    public void Open()
    {
        playerHandUI.SetActive(true);
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
