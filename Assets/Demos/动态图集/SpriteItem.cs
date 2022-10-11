using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

public class SpriteItem : MonoBehaviour
{
    private Image icon;

    private Button clickBtn;

    private void Awake()
    {
        icon = transform.GetComponent<Image>();
        clickBtn = transform.GetComponent<Button>();
    }



    public void AddBtnListener(Action<Sprite> callBack)
    {
        clickBtn.onClick.AddListener(() =>
        {
            callBack(icon.sprite);
        });
    }


    
    /// <summary>
    /// 从静态图集中加载图片
    /// </summary>
    /// <param name="name"></param>
    /// <param name="staticAtlas"></param>
    public void Refresh(string name,string staticAtlas)
    {
        SpriteAtlas spriteAtlas = Resources.Load<SpriteAtlas>(staticAtlas);
        icon.sprite = spriteAtlas.GetSprite(name);

    }
}
