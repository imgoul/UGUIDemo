using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


/// <summary>
/// 3D物体响应点击事件
///     步骤：
///         1.Camera上挂在PhysicRaycaster
///         2.3D物体挂在实现IPointerClick的mono
/// </summary>
public class Click3D : MonoBehaviour,IPointerClickHandler
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
    
}
