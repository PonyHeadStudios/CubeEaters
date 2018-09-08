using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour {

    public MovementScript Player1, Player2;

    private void Start()
    {
        int randomStart = Mathf.RoundToInt(Random.Range(1, 1.01f));
        switch (randomStart)
        {
            case 1:
                Player1.activePlayer = true;
                break;
            default:
                Player2.activePlayer = true;
                break;
        }
    }

    public void SwitchTurns()
    {
        if (Player1.activePlayer)
        {
            Player1.activePlayer = false;
            Player2.activePlayer = true;
        }
        else
        {
            Player2.activePlayer = false;
            Player1.activePlayer = true;
        }
    }
}
