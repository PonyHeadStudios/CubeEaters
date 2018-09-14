using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GameManagerScript : MonoBehaviour {

    public MovementScript Player1, Player2;
    public Tilemap tilemap;
    public GameObject foodInstance;

    const int foodCount = 3;
    private Vector3Int gridSizeSmallInit = new Vector3Int (-3, -3, 0),
                       gridSizeSmallEnd = new Vector3Int(2, 3, 0),
                       gridSizeCompleteInit = new Vector3Int(-5, 3, 0),
                       gridSizeCompleteEnd = new Vector3Int(4, -3, 0);

    private void Start()
    {
        int randomStart = Mathf.RoundToInt(Random.Range(1, 2.01f));
        switch (randomStart)
        {
            case 1:
                Player1.activePlayer = true;
                break;
            default:
                Player2.activePlayer = true;
                break;
        }
        GenerateFood(gridSizeSmallInit, gridSizeSmallEnd);
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

    private void GenerateFood(Vector3Int first, Vector3Int last)
    {
        Vector3Int random1, random2, random3;
        RandomV3Int(out random1, out random2, out random3, first, last);
        Quaternion defaultQ = new Quaternion(0,0,0,0);
        Instantiate(foodInstance, tilemap.GetCellCenterWorld(random1),defaultQ);
        Instantiate(foodInstance, tilemap.GetCellCenterWorld(random2), defaultQ);
        Instantiate(foodInstance, tilemap.GetCellCenterWorld(random3), defaultQ);
    }
    private void RandomV3Int(out Vector3Int r1, out Vector3Int r2, out Vector3Int r3, Vector3Int first, Vector3Int last)
    {
        Vector3 p1Pos = Player1.GetComponent<Transform>().position;
        Vector3 p2Pos = Player2.GetComponent<Transform>().position;
        do
        {
            r1 = ReRollV3(first, last);
        } while (playerPositionCollide(p1Pos,p2Pos,r1));        
        do
        {
            r2 = ReRollV3(first, last);
        } while (r2== r1|| playerPositionCollide(p1Pos, p2Pos, r2));
        do
        {
            r3 = ReRollV3(first, last);
        } while ((r3==r2)||(r3==r1)|| playerPositionCollide(p1Pos, p2Pos, r3));
    }
    private Vector3Int ReRollV3(Vector3Int first, Vector3Int last)
    {
        return new Vector3Int(Random.Range(first.x, last.x +1), Random.Range(first.y, last.y + 1), 0);
    }
    private bool playerPositionCollide(Vector3 player1Pos, Vector3 player2Pos, Vector3 compare)
    {
        if (player1Pos == compare)
        {
            return false;
        }
        if (player2Pos == compare)
        {
            return false;
        }
        return false;
    }
}
