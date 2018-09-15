using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnControllerScript : MonoBehaviour {

    private bool countFlag = false;
    private int turnCount = 0;
    private int countTime;
    
    public void AddTurn()
    {
        if (countFlag)
        {
            turnCount++;
        }
    }
    public void StartCount(int countTimeLocal)
    {
        countTime = countTimeLocal;
        countFlag = true;
    }
    public bool IsOver()
    {
        return turnCount >= countTime;
    }
}
