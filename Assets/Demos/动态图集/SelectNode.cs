using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectNode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Refresh();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Refresh()
    {
        int childCount = transform.childCount;
        for (int i = 0; i < childCount; i++)
        {
            SpriteItem  spriteItem = transform.GetChild(i).GetComponent<SpriteItem>();
            string name = string.Format("sprite{0}", i + 1);
            string staticAtlas = "StaticAtlas";
            spriteItem.Refresh(name,staticAtlas);
        }
    }


    public void AddItemClickListener(Action<Sprite> itemSelect)
    {
        int childCount = transform.childCount;
        for (int i = 0; i < childCount; i++)
        {
            SpriteItem  spriteItem = transform.GetChild(i).GetComponent<SpriteItem>();
            spriteItem.AddBtnListener(itemSelect);
        }

    }
}
