using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectWindow : MonoBehaviour
{
    private SelectNode selectNode;
    private ShowNode showNode;
    private Button finishBtn;


    public LoadingWindow loadingWindow;
    // Start is called before the first frame update
    void Start()
    {
        selectNode = transform.Find("SelectNode").GetComponent<SelectNode>();
        showNode = transform.Find("ShowNode").GetComponent<ShowNode>();


        selectNode.AddItemClickListener(showNode.OnIconSelected);


        finishBtn = transform.Find("CompleteBtn").GetComponent<Button>();
        finishBtn.onClick.AddListener(
            OnCompleteBtnClick
        );
    }

    public void OnCompleteBtnClick()
    {
        //加载过度动画
        
        loadingWindow.gameObject.SetActive(true);
        loadingWindow.ShowAni();

        //打动态图集
        string atlasName = "DynamicAtlas";
        List<Sprite> sprites = showNode.GetToPackSprites();
        SpriteAtlasGenerator.Instantce.GenerateAtlas(atlasName, sprites,
            () => { loadingWindow.SwitchScene("UsingDynamicAtlasScene"); });
    }
}