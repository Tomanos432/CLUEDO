using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dce : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;
    public Roller myRoller;
    public bool One;
    public void Roller()
    {
        if(One)
        myRoller.RollDiceOneFuntion();
        else
            myRoller.RollDiceTwoFuntion();

    }
}
