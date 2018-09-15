using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesHandler : MonoBehaviour {

    private const int defLives = 3;
    private int lives = defLives;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public bool removeLife()
    {
        if (lives == 0)
        {
            return false;
        }
        else
        {
            lives--;
            return true;
        }
    }

    public override string ToString()
    {
        string aux = "";
        for (int i = lives; i > 0; i--)
        {
            aux += "I";
        }
        return aux;
    }
}
