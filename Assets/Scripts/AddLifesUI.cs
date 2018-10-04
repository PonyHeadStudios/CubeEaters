using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AddLifesUI : MonoBehaviour {
    public GameObject prefabFood;
    private int itemIndex = -1;
    public void AddLife()
    {
        GameObject g=Instantiate(prefabFood, gameObject.transform.parent.position, new Quaternion(0, 0, 0, 0));
        g.transform.SetParent(gameObject.transform);
        itemIndex++;
    }

    public void RemoveLife()
    {
        
        if (itemIndex >= 0)
        {
            Transform t = gameObject.transform.GetChild(itemIndex);
            Destroy(t);
            itemIndex--;
        }
    }

    public void RemoveLifeL()
    {
        if (itemIndex >= 0)
        {
            Transform t = gameObject.transform.GetChild(itemIndex);
            Image img = t.GetComponent<Image>();
            img.color = new Color(img.color.r, img.color.g, img.color.b, 0.3f);
            itemIndex--;
        }
    }

    public void AddLifeL()
    {
        Transform t = gameObject.transform.GetChild(itemIndex);
        Image img = t.GetComponent<Image>();
        img.color = new Color(img.color.r, img.color.g, img.color.b, 1f);
        itemIndex++;
    }
}
