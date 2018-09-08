using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MovementScript : MonoBehaviour {

    public TileManagerScript tileManager;

	void Update ()
    {        
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 newPos;
            if (tileManager.CheckValidCell(worldPos, out newPos))
            {
                transform.position = newPos;
            }
                  
        }		
	}    
}
