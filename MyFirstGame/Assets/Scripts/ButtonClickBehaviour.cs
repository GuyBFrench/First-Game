using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class ButtonClickBehaviour : MonoBehaviour
{
    public UnityEvent buttonClickEvent;
    private SolarSystemAttack playerInput;
    public InputValue value;

    private void Awake()
    {
        playerInput = new SolarSystemAttack();
    }

    void Start()
    {
        
    }

    void Update()
    {

    }
}
