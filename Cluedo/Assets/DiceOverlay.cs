using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceOverlay : MonoBehaviour
{
    public static bool IsOpen = false;

	public GameObject diceRollUI;
	// Start is called before the first frame update
    void Update() {
        if (Input.GetKeyDown(KeyCode.D))
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
        diceRollUI.SetActive(false);
        IsOpen = false;
    }
   
    public void Open()
    {
        diceRollUI.SetActive(true);
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
