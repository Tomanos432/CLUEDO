using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChatMenu : MonoBehaviour
{
    public static bool IsOpen = false;
    public GameObject chatUI;

	public void Close()
    {
        chatUI.SetActive(false);
        IsOpen = false;
    }

    public void Open()
    {
        chatUI.SetActive(true);
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
