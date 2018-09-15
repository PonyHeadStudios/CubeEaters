using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovementManagerScript : MonoBehaviour {
    //Inits
    const int maxMov = 3;
    private int actualMov = maxMov;
    //Ref scripts
    public UIHandler myUI;

    private void Update()
    {
        myUI.updateMovs(actualMov);
    }

    public void UsedMovs()
    {
        actualMov--;
    }
    public bool HasMoves()
    {
        if (actualMov != 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void resetMovs()
    {
        actualMov = maxMov;
    }
}
