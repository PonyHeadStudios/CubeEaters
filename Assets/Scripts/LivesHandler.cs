using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesHandler : MonoBehaviour {

    private const int defLives = 3;
    private int lives = defLives;

    public bool RemoveLife()
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

    public bool AddLife()
    {
        if (lives < defLives + 2)
        {
            return false;
        }
        else
        {
            lives++;
            return true;
        }
    }

    public int getDefLives()
    {
        return defLives;
    }

    public int getLeftLives()
    {
        return lives;
    }
}
