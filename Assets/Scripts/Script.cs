using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Script : MonoBehaviour {

    private Tilemap tilemap;

	void Start () {
        tilemap = GetComponent<Tilemap>();
	}

    private void OnMouseDown()
    {
        Vector2 mousePosition = Input.mousePosition;
        Vector2 cameraPosition = Camera.main.GetComponent<Transform>().position;
        RaycastHit2D hitInfo = Physics2D.Raycast(cameraPosition, mousePosition );

        if (hitInfo.collider != null)
        {
            Vector3 asd = tilemap.WorldToCell(hitInfo.collider.transform.localPosition);
            Debug.Log(asd);
            Debug.Log(tilemap.GetTile(Vector3Int.CeilToInt(asd)).name);
        }
        else
        {
            Debug.Log(mousePosition);
            Debug.Log("Nada");
        }
     
    }
}
