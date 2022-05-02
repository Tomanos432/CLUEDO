using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfirmPrompt : MonoBehaviour
{
    public static bool IsOpen = false;
    public GameObject confirmUI;
	public GameObject accusationUI;
    // Update is called once per frame
    void Update()
    {
       
    }
    public void Close()
    {
        confirmUI.SetActive(false);
        IsOpen = false;
    }

    public void Open()
    {
        confirmUI.SetActive(true);
        IsOpen = true;
    }

    public void Confirm()
    {
        Debug.Log("Confirming accusation...");
        //insert logic to lock in accusation values in
        //dropdown boxes
        confirmUI.SetActive(false);
		accusationUI.SetActive(false);
        IsOpen = false;
    }
}
