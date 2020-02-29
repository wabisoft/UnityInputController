using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ControllerNumber
{
    J1 = 1,
    J2 = 2
}

public enum Button
{
    DPadLeft,
    DPadDown,
    DPadRight,
    DPadUp,
    ButtonLeft, // X on Xbox, Square on PS4, Y on Switch, etc.
    ButtonBottom, // A on Xbox, X on PS4, B on Switch, etc.
    ButtonRight, // B on Xbox, Circle on PS4, A on Switch, etc.
    ButtonTop, // Y on Xbox, Triangle on PS4, X on Switch, etc.
    L1, // Left Bumper
    R1, // Right Bumper
    L2, // Left Trigger (digital, use OnLeftTrigger for analog)
    R2, // Right Trigger (digital, use OnRightTrigger for analog)
    L3, // Left stick
    R3, // Right stick
    Start, // What was classically start (Right center button)
    Select, //  What was classically select (Left center button)
            // All Extras are for home button or other system specific weirdness
    Extra1, Extra2, Extra3, Extra4, Extra5, Extra6, Extra7, Extra8, Extra9, Extra10
}

public class InputController : MonoBehaviour
{
    public ControllerNumber Number;
    public InputMap InputMap;

    // Delegates
    public delegate void Stick(float horizontal, float vertical);
    public delegate void DPad(float horizontal, float vertical);
    public delegate void AnalogTrigger(float activation);
    public delegate void ButtonDown(Button button);

    // Events
    public event Stick OnLeftStick;
    public event Stick OnRightStick;
    public event AnalogTrigger OnLeftTrigger;
    public event AnalogTrigger OnRightTrigger;
    public event DPad OnDPad;
    public event ButtonDown OnButtonDown;


    void Start() {
        if (InputMap == null)
        {
            Debug.LogError("You must set the InputMap attribute!");
        }
    }

    void Update() {
        var name = Number.ToString();

        var LeftStickH = (InputMap.LeftStick.Inversion.Horizontal ? -1 : 1) * Input.GetAxis($"{name}{InputMap.LeftStick.Horizontal}");
        var LeftStickV = (InputMap.LeftStick.Inversion.Vertical ? -1 : 1) * Input.GetAxis($"{name}{InputMap.LeftStick.Vertical}");
        if (LeftStickH != 0 || LeftStickV != 0)
        {
            OnLeftStick?.Invoke(LeftStickH, LeftStickV);
        }
        var RightStickH = (InputMap.RightStick.Inversion.Horizontal ? -1 : 1) * Input.GetAxis($"{name}{InputMap.RightStick.Horizontal}");
        var RightStickV = (InputMap.RightStick.Inversion.Vertical ? -1 : 1) * Input.GetAxis($"{name}{InputMap.RightStick.Vertical}");
        if (RightStickH != 0 || RightStickV != 0)
        {
            OnRightStick?.Invoke(RightStickH, RightStickV);
        }
        var DPadH = (InputMap.DPadAxes.Inversion.Horizontal ? -1 : 1) * Input.GetAxis($"{name}{InputMap.DPadAxes.Horizontal}");
        var DPadV = (InputMap.DPadAxes.Inversion.Vertical ? -1 : 1) * Input.GetAxis($"{name}{InputMap.DPadAxes.Vertical}");
        if (DPadH != 0 || DPadV != 0)
        {
            OnDPad?.Invoke(DPadH, DPadV);
        }
        var L2Analog = Input.GetAxis($"{name}{InputMap.L2Analog}");
        if (L2Analog != 0) { OnLeftTrigger?.Invoke(L2Analog); }
        var R2Analog = Input.GetAxis($"{name}{InputMap.R2Analog}");
        if (R2Analog != 0) { OnRightTrigger?.Invoke(R2Analog); }

        if (Input.GetButtonDown($"{name}{InputMap.DPadButtons.Left}")) { OnButtonDown?.Invoke(Button.DPadLeft); }
        if (Input.GetButtonDown($"{name}{InputMap.DPadButtons.Down}")) { OnButtonDown?.Invoke(Button.DPadDown); }
        if (Input.GetButtonDown($"{name}{InputMap.DPadButtons.Right}")) { OnButtonDown?.Invoke(Button.DPadRight); }
        if (Input.GetButtonDown($"{name}{InputMap.DPadButtons.Up}")) { OnButtonDown?.Invoke(Button.DPadUp); }
        if (Input.GetButtonDown($"{name}{InputMap.L1}")) { OnButtonDown?.Invoke(Button.L1); }
        if (Input.GetButtonDown($"{name}{InputMap.R1}")) { OnButtonDown?.Invoke(Button.R1); }
        if (Input.GetButtonDown($"{name}{InputMap.L2}")) { OnButtonDown?.Invoke(Button.L2); }
        if (Input.GetButtonDown($"{name}{InputMap.R2}")) { OnButtonDown?.Invoke(Button.R2); }
        if (Input.GetButtonDown($"{name}{InputMap.LeftStick.Press}")) { OnButtonDown?.Invoke(Button.L3); }
        if (Input.GetButtonDown($"{name}{InputMap.RightStick.Press}")) { OnButtonDown?.Invoke(Button.R3); }
        if (Input.GetButtonDown($"{name}{InputMap.ButtonLeft}")) { OnButtonDown?.Invoke(Button.ButtonLeft); }
        if (Input.GetButtonDown($"{name}{InputMap.ButtonBottom}")) { OnButtonDown?.Invoke(Button.ButtonBottom); }
        if (Input.GetButtonDown($"{name}{InputMap.ButtonRight}")) { OnButtonDown?.Invoke(Button.ButtonRight); }
        if (Input.GetButtonDown($"{name}{InputMap.ButtonTop}")) { OnButtonDown?.Invoke(Button.ButtonTop); }
        if (Input.GetButtonDown($"{name}{InputMap.Start}")) { OnButtonDown?.Invoke(Button.Start); }
        if (Input.GetButtonDown($"{name}{InputMap.Select}")) { OnButtonDown?.Invoke(Button.Select); }
        if (Input.GetButtonDown($"{name}{InputMap.Extra1}")) { OnButtonDown?.Invoke(Button.Extra1); }
        if (Input.GetButtonDown($"{name}{InputMap.Extra2}")) { OnButtonDown?.Invoke(Button.Extra2); }
        if (Input.GetButtonDown($"{name}{InputMap.Extra3}")) { OnButtonDown?.Invoke(Button.Extra3); }
        if (Input.GetButtonDown($"{name}{InputMap.Extra4}")) { OnButtonDown?.Invoke(Button.Extra4); }
        if (Input.GetButtonDown($"{name}{InputMap.Extra5}")) { OnButtonDown?.Invoke(Button.Extra5); }
        if (Input.GetButtonDown($"{name}{InputMap.Extra6}")) { OnButtonDown?.Invoke(Button.Extra6); }
        if (Input.GetButtonDown($"{name}{InputMap.Extra7}")) { OnButtonDown?.Invoke(Button.Extra7); }
        if (Input.GetButtonDown($"{name}{InputMap.Extra8}")) { OnButtonDown?.Invoke(Button.Extra8); }
        if (Input.GetButtonDown($"{name}{InputMap.Extra9}")) { OnButtonDown?.Invoke(Button.Extra9); }
        if (Input.GetButtonDown($"{name}{InputMap.Extra10}")) { OnButtonDown?.Invoke(Button.Extra10); }
    }
}
