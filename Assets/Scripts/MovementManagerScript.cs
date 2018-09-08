using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovementManagerScript : MonoBehaviour {

    const int maxMov = 3;
    private Text movementsText;
    private int actualMov = maxMov;

    private void Start()
    {
        movementsText = GetComponent<Text>();
    }

    private void Update()
    {
        movementsText.text = actualMov.ToString();
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
