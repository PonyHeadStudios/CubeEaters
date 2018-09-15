using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TileTipo", menuName = "Nueva Tile")]
public class GeneradorDeTiles : ScriptableObject {

    public enum Tipo {Normal,Montaña,Portal,Agua};
    public Tipo type;
    public int modTurns;
    public Sprite artwork;
    public bool validTile;

}
