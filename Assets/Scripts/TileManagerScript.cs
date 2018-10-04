using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileManagerScript : MonoBehaviour {

    private Tilemap groundTilemap;
    public TileBehaviour tileBehaviour = new TileBehaviour();
    public TileData[] tileLoads = new TileData[0];

    private void Start()
    {
        for (int i = 0; i < tileLoads.Length; i++)
        {
            tileBehaviour.AddTile(tileLoads[i]);
        }
        groundTilemap = GetComponent<Tilemap>();
    }

    private void Update()
    {
    //TileChecker
    /*    if (Input.GetMouseButtonDown(0))
        {
            Debug.Log(groundTilemap.WorldToCell(Camera.main.ScreenToWorldPoint(Input.mousePosition)));
        }   */
    }

    public bool CheckValidCell (Vector3 v3, out Vector3 newPos, out Vector3Int nextPos) 
    {
        Vector3Int worldPosInt = groundTilemap.WorldToCell(v3);
        Tile tileClicked = groundTilemap.GetTile<Tile>(worldPosInt);
        newPos = groundTilemap.GetCellCenterWorld(worldPosInt);
        nextPos = worldPosInt;
        if (tileClicked != null)
        {
            TileData data = tileBehaviour.FindTile(tileClicked.name);
            if (data != null)
            {
                return data.isValid;
            }
            else return false;
        }
        else return false;           
    }

    public class TileBehaviour
    {
        private ArrayList tileData = new ArrayList();

        //Methods-----------

            public void AddTile(TileData tile)
        {
            tileData.Add(tile);
        }

        public TileData FindTile(string name)
        {
            TileData auxTile = null;
            foreach (var item in tileData)
            {
                if (item != null)
                {
                    auxTile = (TileData)item;
                    if (auxTile.id == name)
                        return auxTile;
                }

            }
            return null;
        }
    }
    [CreateAssetMenu()]
    public class TileData : ScriptableObject
    {
        public string id;
        public bool isValid = true;
        public bool isImmediate = true;

        public void Action(LivesHandler p)
        {
            
            switch (id)
            {
                case "Circle":
                
                default:
                {} break;
            }
        }
    }
}
