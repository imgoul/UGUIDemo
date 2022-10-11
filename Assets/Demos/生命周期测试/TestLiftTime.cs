using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestLiftTime : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("TestLifeTime.Awake");
        Debug.Log(String.Format("TestLifeTime.Awake\n\t gameObject.activeInHierarchy:{0}\n\t gameObject.activeSelf:{1} ",
            gameObject.activeInHierarchy, gameObject.activeSelf));
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("TestLifeTime.Start");
    }

    // Update is called once per frame
    /*void Update()
    {
        Debug.Log("TestLifeTime.Update");
    }*/

    private void Reset()
    {
        Debug.Log("TestLifeTime.Reset");
    }

    /*private void FixedUpdate()
    {
        Debug.Log("TestLifeTime.FixedUpdate");
    }

    private void LateUpdate()
    {
        Debug.Log("TestLifeTime.LateUpdate");
    }*/

    private void OnEnable()
    {
        Debug.Log("TestLifeTime.OnEnable");
    }

    private void OnDisable()
    {
        Debug.Log("TestLifeTime.OnDisable");
    }

    private void OnDestroy()
    {
        Debug.Log("TestLifeTime.OnDestroy");
    }


    private void OnAnimatorIK(int layerIndex)
    {
        Debug.Log("TestLifeTime.OnAnimatorIK(layerIndex)  " + layerIndex);
    }

    private void OnAnimatorMove()
    {
        Debug.Log("TestLiftTime.OnValidate");
    }

    private void OnApplicationFocus(bool hasFocus)
    {
        Debug.Log("TestLiftTime.OnValidate");
    }

    private void OnApplicationPause(bool pauseStatus)
    {
        Debug.Log("TestLiftTime.OnValidate");
    }

    private void OnApplicationQuit()
    {
        Debug.Log("TestLiftTime.OnValidate");
    }

    private void OnAudioFilterRead(float[] data, int channels)
    {
        Debug.Log("TestLiftTime.OnValidate");
    }

    private void OnBecameInvisible()
    {
        Debug.Log("TestLiftTime.OnValidate");
    }

    private void OnBecameVisible()
    {
        Debug.Log("TestLiftTime.OnBecameVisible");
    }

    private void OnBeforeTransformParentChanged()
    {
        Debug.Log("TestLiftTime.OnBeforeTransformParentChanged");
    }

    private void OnCanvasGroupChanged()
    {
        Debug.Log("TestLiftTime.OnCanvasGroupChanged");
    }

    private void OnCanvasHierarchyChanged()
    {
        Debug.Log("TestLiftTime.OnCanvasHierarchyChanged");
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("TestLiftTime.OnCollisionEnter");
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("TestLiftTime.OnCollisionEnter2D");
    }

    private void OnCollisionExit(Collision other)
    {
        Debug.Log("TestLiftTime.OnCollisionExit");
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        Debug.Log("TestLiftTime.OnCollisionExit2D");
    }

    private void OnCollisionStay(Collision collisionInfo)
    {
        Debug.Log("TestLiftTime.OnCollisionStay");
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("TestLiftTime.OnCollisionStay2D");
    }

    private void OnConnectedToServer()
    {
        Debug.Log("TestLiftTime.OnConnectedToServer");
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Debug.Log("TestLiftTime.OnControllerColliderHit");
    }

    private void OnDidApplyAnimationProperties()
    {
        Debug.Log("TestLiftTime.OnDidApplyAnimationProperties");
    }

    /*private void OnDrawGizmos()
    {
        Debug.Log("TestLiftTime.OnDrawGizmos");
    }

    private void OnDrawGizmosSelected()
    {
        Debug.Log("TestLiftTime.OnDrawGizmosSelected");
    }*/

    private void OnJointBreak(float breakForce)
    {
        Debug.Log("TestLiftTime.OnJointBreak");
    }

    private void OnJointBreak2D(Joint2D brokenJoint)
    {
        Debug.Log("TestLiftTime.OnJointBreak2D");
    }

    private void OnMouseDown()
    {
        Debug.Log("TestLiftTime.OnMouseDown");
    }

    private void OnMouseDrag()
    {
        Debug.Log("TestLiftTime.OnMouseDrag");
    }

    private void OnMouseEnter()
    {
        Debug.Log("TestLiftTime.OnMouseEnter");
    }

    private void OnMouseExit()
    {
        Debug.Log("TestLiftTime.OnMouseExit");
    }

    private void OnMouseOver()
    {
        Debug.Log("TestLiftTime.OnMouseOver");
    }

    private void OnMouseUp()
    {
        Debug.Log("TestLiftTime.OnMouseUp");
    }

    private void OnMouseUpAsButton()
    {
        Debug.Log("TestLiftTime.OnMouseUpAsButton");
    }

    private void OnParticleCollision(GameObject other)
    {
        Debug.Log("TestLiftTime.OnParticleCollision");
    }

    private void OnParticleSystemStopped()
    {
        Debug.Log("TestLiftTime.OnParticleSystemStopped");
    }

    private void OnParticleTrigger()
    {
        Debug.Log("TestLiftTime.OnParticleTrigger");
    }

    private void OnParticleUpdateJobScheduled()
    {
        Debug.Log("TestLiftTime.OnParticleUpdateJobScheduled");
    }

    private void OnPostRender()
    {
        Debug.Log("TestLiftTime.OnPostRender");
    }

    private void OnPreCull()
    {
        Debug.Log("TestLiftTime.OnPreCull");
    }

    private void OnPreRender()
    {
        Debug.Log("TestLiftTime.OnPreRender");
    }

    private void OnRectTransformDimensionsChange()
    {
        Debug.Log("TestLiftTime.OnRectTransformDimensionsChange");
    }

    private void OnRenderImage(RenderTexture src, RenderTexture dest)
    {
        Debug.Log("TestLiftTime.OnRenderImage");
    }

    private void OnRenderObject()
    {
        //Debug.Log("TestLiftTime.OnRenderObject");
    }

    private void OnServerInitialized()
    {
        Debug.Log("TestLiftTime.OnServerInitialized");
    }

    private void OnTransformChildrenChanged()
    {
        Debug.Log("TestLiftTime.OnTransformChildrenChanged");
    }

    private void OnTransformParentChanged()
    {
        Debug.Log("TestLiftTime.OnTransformParentChanged");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("TestLiftTime.OnTriggerEnter");
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("TestLiftTime.OnTriggerEnter2D");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("TestLiftTime.OnTriggerExit");
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("TestLiftTime.OnTriggerExit2D");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("TestLiftTime.OnTriggerStay");
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("TestLiftTime.OnTriggerStay2D");
    }

    private void OnValidate()
    {
        Debug.Log("TestLiftTime.OnValidate");
    }

    private void OnWillRenderObject()
    {
        //Debug.Log("TestLiftTime.OnWillRenderObject");
    }
}