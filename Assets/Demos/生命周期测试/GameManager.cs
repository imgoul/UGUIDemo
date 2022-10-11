using System;
using System.Collections;
using System.Collections.Generic;
using EnhancedScrollerDemos.GridSimulation;
using Unity.Collections;
using UnityEngine;
using UnityEngine.UI;
using Object = System.Object;

public class GameManager : MonoBehaviour
{
    public Button loadBtn;
    public Button instantiateBtn;
    
    
    private GameObject cubePrefab = null;

    private void Awake()
    {
        Debug.Log("GameManager.Awake");
    }

    // Start is called before the first frame update
    void Start()
    {
        /*if (loadBtn == null)
        {
            Debug.LogError("loadBtn is null");
            return;
        }

        if (instantiateBtn==null)
        {
            Debug.LogError("instantiateBtn is null");
            return;
        }

        loadBtn.onClick.AddListener(LoadPrefab);
        instantiateBtn.onClick.AddListener(InstantiatePrefab);*/
    }



    public void LoadPrefab()
    {
        Debug.Log("GameManager.LoadPrefab");
        cubePrefab = Resources.Load<GameObject>("CubePrefab");
        if (cubePrefab==null)
        {
            Debug.LogError("加载CubePrefab失败");
        }

        this.StartCoroutine(TestCor());
    }

    public void InstantiatePrefab()
    {
        Debug.Log("GameManager.InstanitatePrefab");
        if (cubePrefab == null)
        {
            Debug.LogError("CubePrefab is null");
            return;
        }

        UnityEngine.Object.Instantiate<GameObject>(cubePrefab);

        GameObject sonNode = cubePrefab.transform.Find("Cube").gameObject;
        Debug.Log(String.Format("SonNode:Cube\n\t sonNodeCube.activeInHierarchy:{0}\n\t sonNodeCube.activeSelf:{1} ",
            sonNode.activeInHierarchy, sonNode.activeSelf));
        TestLiftTime liftTime =  sonNode.transform.GetComponent<TestLiftTime>();
        Debug.Log("sonNodeCube的TestLiftTime.enabled:"+liftTime.enabled);
    }


    private long maxtime = 200000;
    IEnumerator TestCor()
    {
        long lastYieldTime = DateTime.Now.Ticks;
        while (true)
        {
            bool hasYield = false;


            if (!hasYield || DateTime.Now.Ticks - lastYieldTime >= maxtime)
            {
                Debug.Log("llll : yield return 前");
                yield return null;
                Debug.Log("llll  yield return null后");
                lastYieldTime = DateTime.Now.Ticks;
            }
        }
        
    }


    private void Update()
    {
        Debug.Log("llll   update");
    }
}
