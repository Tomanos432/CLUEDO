using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuggestionPrompt : MonoBehaviour
{
    public static bool IsOpen = false;
    public GameObject suggestionUI;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
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
        suggestionUI.SetActive(false);
        IsOpen = false;
    }

    public void Open()
    {
        suggestionUI.SetActive(true);
        IsOpen = true;
    }

    public void Confirm()
    {
        Debug.Log("Confirming suggestion...");
        //insert logic to lock in suggestion values in
        //dropdown boxes
        suggestionUI.SetActive(false);
        IsOpen = false;
    }
}
