using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Roller : MonoBehaviour
{
    public Sprite[] DiceImages;
    public Image One, Two;
    int currentVal;
    public int DiceOneValue, DiceTwoValue;
    // Start is called before the first frame update

    public void Roll()
    {
        One.gameObject.GetComponent<Animator>().enabled = true;
        One.gameObject.GetComponent<Animator>().ResetTrigger("RollDice");
        One.gameObject.GetComponent<Animator>().SetTrigger("RollDice");
    }
    public void RollDiceOneFuntion()
    {
        One.gameObject.GetComponent<Animator>().enabled = false;
        One.sprite = RollDice();
        DiceOneValue = currentVal;
        Two.gameObject.GetComponent<Animator>().enabled = true;
        Two.gameObject.GetComponent<Animator>().ResetTrigger("RollDice");
        Two.gameObject.GetComponent<Animator>().SetTrigger("RollDice");
    }

    public void RollDiceTwoFuntion()
    {
        Two.gameObject.GetComponent<Animator>().enabled = false;
        Two.sprite = RollDice();
        DiceTwoValue = currentVal;
    }

    public Sprite RollDice()
    {
        int x = Mathf.RoundToInt(Random.Range(0, DiceImages.Length - 1));
        currentVal = x + 1;
        return DiceImages[x];
    }
}
