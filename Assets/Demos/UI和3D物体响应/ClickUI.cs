using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ClickUI : MonoBehaviour,IPointerClickHandler
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        ChangeColor();
        ExecuteAll(eventData);
        
        
    }

    private int _index = 0;
    private void ChangeColor()
    {
        Image image = transform.GetComponent<Image>();
        
        if (_index == 0)
        {
            image.color = Color.magenta;

        }
        else
        {
            image.color = Color.yellow;
            
        }

        _index = _index == 1 ? 0 : 1;
    }

    /// <summary>
    /// 触发被此UI遮挡的物体的点击事件
    /// </summary>
    /// <param name="eventData"></param>
    private void ExecuteAll(PointerEventData eventData)
    {
        List<RaycastResult> raycastResults = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventData,raycastResults);
        foreach (var result in raycastResults)
        {
            if (result.gameObject == gameObject)
            {
                continue;
            }

            ExecuteEvents.Execute(result.gameObject, eventData, ExecuteEvents.pointerClickHandler);
        }
    }

    

}
