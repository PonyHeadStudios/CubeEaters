using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MovementScript : MonoBehaviour {

    public TileManagerScript tileManager;
    public Tilemap tileMap;
    public MovementManagerScript movementManager;

    public bool activePlayer = false;
    private Vector3Int myTile;

    private int mass = 0;

    private void Start()
    {
        resetTile();
    }

    void Update ()
    {        
        if (activePlayer && Input.GetMouseButtonDown(0))
        {
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 newPos;
            Vector3Int nextPos;
            if (tileManager.CheckValidCell(worldPos, out newPos, out nextPos))
            {
                if (CheckAdjacent(nextPos) && movementManager.HasMoves())
                {
                    transform.position = newPos;
                    movementManager.UsedMovs();
                    myTile = tileMap.WorldToCell(transform.position);
                }                
            }                  
        }
	}

    public void UpdateMass()
    {
        mass++;
    }

    private bool CheckAdjacent(Vector3Int nextPos)
    {
        if ((myTile.x == nextPos.x)&&(Mathf.Abs(myTile.y-nextPos.y) == 1))
        {
            return true;
        } 
        if ((myTile.y == nextPos.y) && (Mathf.Abs(myTile.x - nextPos.x) == 1))
        {
            return true;
        }
        if ((Mathf.Abs(myTile.y - nextPos.y) == 1) && (Mathf.Abs(myTile.x - nextPos.x) == 1))
        {
            return true;
        }
            return false;
    }

    public int getMass()
    {
        return mass;
    }

    public void resetTile()
    {
        myTile = tileMap.WorldToCell(transform.position);
    }
}
