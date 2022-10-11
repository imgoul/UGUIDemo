using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteAtlasGenerator : MonoBehaviour
{
    private static SpriteAtlasGenerator instantce;

    public static SpriteAtlasGenerator Instantce
    {
        get { return instantce; }
    }

    private void Awake()
    {
        if (instantce == null)
        {
            instantce = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            //切场景时，销毁新创建的GameObject
            Destroy(gameObject);
        }
    }

    
    /// <summary>
    /// TODO 生成动态图集
    /// </summary>
    /// <param name="atlasName"></param>
    /// <param name="sprites"></param>
    /// <param name="onComplete"></param>
    public void GenerateAtlas(string atlasName, List<Sprite> sprites,Action onComplete)
    {
        
    }
}