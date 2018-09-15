using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonScript : MonoBehaviour, IPointerClickHandler {

    public GameManagerScript gameManager;

    void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
    {
        gameManager.clearTurn();
    }
}
