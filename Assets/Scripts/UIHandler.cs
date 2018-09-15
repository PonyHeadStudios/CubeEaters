using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

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
    }

    public void updateScreen()
    {
        livesp1UI.text = "Lives "+livesp1.ToString();
        livesp2UI.text = "Lives "+livesp2.ToString();
    }
}
