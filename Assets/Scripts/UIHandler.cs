using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIHandler : MonoBehaviour {
    //ref UI
    public Text leftMovesUI;
    //ref scripts
    public LivesHandler livesp1;
    public LivesHandler livesp2;
    public AddLifesUI lifeDisplayer1;
    public AddLifesUI lifeDisplayer2;
    //Inits
    private int leftp1;
    private int leftp2;

    private void Awake()
    {
        leftp1 = livesp1.getDefLives();
        leftp2 = livesp2.getDefLives();
    }




    public void OnEnable()
    {        
        lifeDisplayer1.AddLife();
        lifeDisplayer1.AddLife();
        lifeDisplayer1.AddLife();
        lifeDisplayer2.AddLife();
        lifeDisplayer2.AddLife();
        lifeDisplayer2.AddLife();
    }

    public void updateMovs(int movs,int max)
    {
        leftMovesUI.text = movs.ToString();
        if (movs==max)
            checkTextBG(leftMovesUI);
    }

    private void checkTextBG(Text t)
    {
        Image leftMovsBG = t.GetComponentInParent<Image>();
        GameObject[] p = GameObject.FindGameObjectsWithTag("Player");
        for (int i = 0; i < p.Length; i++)
        {
            if (p[i].GetComponent<MovementScript>().activePlayer)
            {
                SpriteRenderer render = p[i].GetComponent<SpriteRenderer>();
                leftMovsBG.color = render.color;
            }
        }
    }

    public void updateScreen()
    {
        if (livesp1.getLeftLives() > leftp1)
        {
            lifeDisplayer1.AddLifeL();
            leftp1++;
        }
        else
        {
            if (livesp1.getLeftLives() < leftp1)
            {
                lifeDisplayer1.RemoveLifeL();
                leftp1--;
            }
        }
        if (livesp2.getLeftLives() > leftp2)
        {
            lifeDisplayer2.AddLifeL();
            leftp2++;
        }
        else
        {
            if (livesp2.getLeftLives() < leftp2)
            {
                lifeDisplayer2.RemoveLifeL();
                leftp2--;
            }
        }
    }
}
