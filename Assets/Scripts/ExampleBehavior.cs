﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleBehavior : InputListener
{
    void Start() {
        Subscribe(InputController);
    }

    public override void OnLeftStick(float horizontal, float vertical) {
        Debug.Log($"OnLeftStick: ({horizontal}, {vertical})");
    }

    public override void OnRightStick(float horizontal, float vertical) {
        Debug.Log($"OnRightStick: ({horizontal}, {vertical})");
    }

    public override void OnButtonDown(Button button) {
        Debug.Log($"Button: {button}");
    }

    public override void OnDPad(float horizontal, float vertical) {
        Debug.Log($"OnDPad: ({horizontal}, {vertical})");
    }
}
