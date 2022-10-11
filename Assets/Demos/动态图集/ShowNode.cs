using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ShowNode : MonoBehaviour
{
    private  int selectIndex = -1;
    // Start is called before the first frame update
    void Start()
    {
        int childCount = transform.childCount;
        for (int i = 0; i < childCount; i++)
        {
            Button btn = transform.GetChild(i).GetComponent<Button>();

            int index = i + 1;
            btn.onClick.AddListener(() =>
            {
                Debug.Log("SelectIndex:"+index);
                selectIndex = index;
            });
        }
    }

    
    public void OnIconSelected(Sprite sprite)
    {
        if (selectIndex!=-1)
        {
            Image target = transform.Find("Icon" + selectIndex).GetComponent<Image>();
            target.sprite = sprite;
        }
        
    }


    public List<Sprite> GetToPackSprites()
    {
        List<Sprite> list = new List<Sprite>();
        int childCount = transform.childCount;
        for (int i = 0; i < childCount; i++)
        {
            Image img = transform.GetChild(i).GetComponent<Image>();
            list.Add(img.sprite);
        }

        return list;
    }
}
