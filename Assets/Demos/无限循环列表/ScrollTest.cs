using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<ScrollRect>().onValueChanged.AddListener(onScrollValueChanged);
    }

    private List<int> _list = new List<int>();
    private Dictionary<int, int> _dictionary = new Dictionary<int, int>();

    private void onScrollValueChanged(Vector2 val)
    {
        Debug.Log("lll:"+val.ToString());
        
        _dictionary.Clear();
        
    }

    // Update is called once per frame


}
