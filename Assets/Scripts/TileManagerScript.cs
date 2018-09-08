using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileManagerScript : MonoBehaviour {

    private Tilemap groundTilemap;

    private void Start()
    {
        groundTilemap = GetComponent<Tilemap>();
    }

    public bool CheckValidCell (Vector3 v3, out Vector3 newPos) 
    {
        Vector3Int worldPosInt = groundTilemap.WorldToCell(v3);
        Tile tileClicked = groundTilemap.GetTile<Tile>(worldPosInt);
        newPos = groundTilemap.GetCellCenterWorld(worldPosInt);        
        if (tileClicked != null)
        {
            if (tileClicked.name == "Square") //Cuando haya mas cuadros, crear metodo de verificacion
            {
                
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }            
    }
}
