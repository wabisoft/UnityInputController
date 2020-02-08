using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputListener : MonoBehaviour
{
    public InputController InputController;

    public virtual void Subscribe(InputController inputController)
    {
        inputController.OnLeftStick += OnLeftStick;
        inputController.OnRightStick += OnRightStick;
        inputController.OnLeftTrigger += OnLeftTrigger;
        inputController.OnRightTrigger += OnLeftTrigger;
        inputController.OnDPad += OnDPad;
        inputController.OnButtonDown += OnButtonDown;

    }

    public virtual void Unsubscribe(InputController inputController)
    {
        inputController.OnLeftStick -= OnLeftStick;
        inputController.OnRightStick -= OnRightStick;
        inputController.OnLeftTrigger -= OnLeftTrigger;
        inputController.OnRightTrigger -= OnLeftTrigger;
        inputController.OnDPad -= OnDPad;
        inputController.OnButtonDown -= OnButtonDown;
    }

    public virtual void OnLeftStick(float horizontal, float vertical) { }
    public virtual void OnRightStick(float horizontal, float vertical) { }
    public virtual void OnLeftTrigger(float activation) { }
    public virtual void OnRightTrigger(float activation) { }
    public virtual void OnDPad(float horizontal, float vertical) { }
    public virtual void OnButtonDown(Button button) { }

}
