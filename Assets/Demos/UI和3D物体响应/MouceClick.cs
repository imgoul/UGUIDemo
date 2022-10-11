using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


/// <summary>
/// 过滤UI响应事件
/// </summary>
public class MouceClick : MonoBehaviour
{
    private GraphicRaycaster _graphicRaycaster;
    // Start is called before the first frame update
    void Start()
    {
        _graphicRaycaster = FindObjectOfType<GraphicRaycaster>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)&&!IsUI())
        {
            ChangeColor();
        }
    }

    private int _index = 0;
    private void ChangeColor()
    {
        Material material = transform.GetComponent<MeshRenderer>().material;
        if (_index == 0)
        {
            material.color = Color.green;
        }
        else
        {
            material.color = Color.blue;
            
        }

        _index = _index == 1 ? 0 : 1;

    }
    private bool IsUI()
    {
        PointerEventData eventData = new PointerEventData(EventSystem.current);
        eventData.position = Input.mousePosition;//当前位置，拖拽事件要用
        eventData.pressPosition = Input.mousePosition;//按下的位置
        List<RaycastResult> raycastResults = new List<RaycastResult>();
        _graphicRaycaster.Raycast(eventData,raycastResults);

        return raycastResults.Count > 0;
    }
}
