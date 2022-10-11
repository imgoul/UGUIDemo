using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


/// <summary>
/// 事件交互的三种方式：
///
/// 方法1：之间使用现有的UGUI组件 
///
/// 方法2：给GameObject添加Event Trigger
///     EventTrigger trigger = GetComponent<EventTrigger>();
///     EventTrigger.Entry entry = new EventTrigger.Entry();
///     entry.eventID = EventTriggerType.PointerDown;
///     entry.callback.AddListener((data) => { OnPointerDownDelegate((PointerEventData)data); });
///     trigger.triggers.Add(entry);
/// 
///    1.GameObject添加EventTrigger
///    2. 创建EventTriger.Entry对象
///     3.entry设置eventID和callback监听事件
///     3.eventtrigger添加entry
///
/// 方法3：实现具体的接口，或者继承eventTrigger
/// 
/// </summary>
public class EventTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
            EventTrigger trigger = gameObject.AddComponent<EventTrigger>();
            EventTrigger.Entry entry = new EventTrigger.Entry();
            entry.eventID = EventTriggerType.PointerDown;
            entry.callback.AddListener((data) =>
            {
                
                Debug.Log("trigger event添加的事件");
            });
            trigger.triggers.Add(entry);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
