using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ChangeTargetPlanetBehavior : MonoBehaviour
{
    public GameObject planet;
    public UnityEvent onClickEvent;
    void Start()
    {
        
    }

    public void OnMouseDown()
    {
        onClickEvent.Invoke();
    }
}
