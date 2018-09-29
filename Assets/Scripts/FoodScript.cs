using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodScript : MonoBehaviour {

    private Vector3[] playerPos = new Vector3[2];
    private GameObject[] playerRefs;
    private Transform[] playerTrans = new Transform[2];
    public Sprite[] sprites;


    private void Start()
    {
        playerRefs = GameObject.FindGameObjectsWithTag("Player");
        playerTrans[0] = playerRefs[0].GetComponent<Transform>();
        playerTrans[1] = playerRefs[1].GetComponent<Transform>();
        Sprite mSprite = sprites[(int)Random.Range(0, sprites.Length)];
        gameObject.GetComponent<SpriteRenderer>().sprite = mSprite;
    }

    void Update () {

        playerPos[0] = playerTrans[0].position;
        playerPos[1] = playerTrans[1].position;
        if (this.transform.position == playerPos[0])
        {
            playerRefs[0].GetComponent<MovementScript>().UpdateMass();
            Destroy(this.gameObject);
        }
        if (this.transform.position == playerPos[1])
        {
            playerRefs[1].GetComponent<MovementScript>().UpdateMass();
            Destroy(this.gameObject);
        }
    }
}
