﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleBehavior : InputListener
{
    // Start is called before the first frame update
    void Start()
    {
        Subscribe(InputController);
    }

    void Update() { }

    public override void OnLeftStick(float horizontal, float vertical) {
        Debug.Log($"OnLeftStick({horizontal}, {vertical})");
    }

    public override void OnButtonDown(Button button) {
        Debug.Log($"Button: {button}");
    }
}