using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingWindow : MonoBehaviour
{
    public void ShowAni()
    {
        transform.Find("Text").GetComponent<Text>().DOText("Loading",3).SetLoops(-1,LoopType.Restart);
    }


    public void SwitchScene(string sceneName)
    {
        StartCoroutine(AsyncLoadScene(sceneName));
    }


    private IEnumerator AsyncLoadScene(string sceneName)
    {
        AsyncOperation asyn = SceneManager.LoadSceneAsync(sceneName);
        asyn.allowSceneActivation = false;

        while (!asyn.isDone)
        {
            if (asyn.progress>=0.9f)
            {
                yield return new WaitForSeconds(1.5f);
                asyn.allowSceneActivation = true;
            }

            yield return new WaitForSeconds(0.3f);
        }
    }

}
