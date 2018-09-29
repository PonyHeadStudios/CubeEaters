using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIHandler : MonoBehaviour {
    //ref UI
	public Text livesp1UI;
    public Text livesp2UI;
    public Text leftMovesUI;
    //ref scripts
    public LivesHandler livesp1;
    public LivesHandler livesp2;

    public void updateMovs(int n)
    {
        leftMovesUI.text = n.ToString();
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
        livesp1UI.text = "Lives "+livesp1.ToString();
        livesp2UI.text = "Lives "+livesp2.ToString();
    }
}
