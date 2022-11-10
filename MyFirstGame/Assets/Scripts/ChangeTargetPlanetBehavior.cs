using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ChangeTargetPlanetBehavior : MonoBehaviour
{
    public GameObject planet;
    public UnityEvent onClickEvent, healthCheckEvent, updateLocationEvent;
    public bool canRun = false;
    private WaitForSeconds wsfObj;
    public float seconds = 0f;
    void Start()
    {
        wsfObj = new WaitForSeconds(seconds);
    }

    public void OnMouseDown()
    {
        onClickEvent.Invoke();
    }
    
    public void HealthCheck(IntData1 obj)
    {
        if (obj.value > 0)
        {
            
        }
        else
        {
            healthCheckEvent.Invoke();
        }
    }
    
    public bool CanRun
    {
        get => canRun;
        set => canRun = value;
    }

    public void StartUpdatingPosition()
    {
        canRun = true;
        StartCoroutine(UpdatingPosition());
    }

    public IEnumerator UpdatingPosition()
    {
        while (canRun)
        {
            yield return wsfObj; 
            updateLocationEvent.Invoke();
        }
    }
}
