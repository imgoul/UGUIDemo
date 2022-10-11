using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    public Canvas parent;
    public Canvas son;
    void Start()
    {
        Debug.Log("parent:"+parent.sortingLayerName);
        Debug.Log("son:"+son.sortingLayerName);
        

    }

    /// <summary>
    /// 子Canvas开启 override sorting 只会影响sorting order
    /// </summary>
    
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
