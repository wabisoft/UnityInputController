using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum InputAxis
{
    A0, A1, A2, A3, A4, A5, A6, A7, A8, A9, A10, A11, A12, A13, A14, A15, A16, A17, A18, A19, A20, A21, A22, A23, A24, A25, A26, A27, NONE
}

public enum InputButton
{
    B0, B1, B2, B3, B4, B5, B6, B7, B8, B9, B10, B11, B12, B13, B14, B15, B16, B17, B18, B19, NONE
}

[System.Serializable]
public class AxisInversion {
    public bool Horizontal = false;
    public bool Vertical = false;
}

[System.Serializable]
public class ControlStick {
    public InputAxis Horizontal = InputAxis.NONE;
    public InputAxis Vertical = InputAxis.NONE;
    public InputButton Press = InputButton.NONE;
    public AxisInversion Inversion;
}

[System.Serializable]
public class DPadAxes {
    public InputAxis Horizontal = InputAxis.NONE; // assuming 1 for right and -1 for left
    public InputAxis Vertical = InputAxis.NONE; // assuming 1 for up and -1 for down
    public AxisInversion Inversion; // flip assumption
}

[System.Serializable]
public class DPadButtons {
    public InputButton Left = InputButton.NONE;
    public InputButton Down = InputButton.NONE;
    public InputButton Right = InputButton.NONE;
    public InputButton Up = InputButton.NONE;
}


[CreateAssetMenu(fileName = "InputMap", menuName = "ScriptableObjects/Input Map", order = 1)]
public class InputMap : ScriptableObject
{
    public string Name;
    public ControlStick LeftStick;
    public ControlStick RightStick;
    public DPadAxes DPadAxes;
    public InputAxis L2Analog = InputAxis.NONE;
    public InputAxis R2Analog = InputAxis.NONE;

    public DPadButtons DPadButtons;
    public InputButton L1 = InputButton.NONE;
    public InputButton R1 = InputButton.NONE;
    public InputButton L2 = InputButton.NONE;
    public InputButton R2 = InputButton.NONE;
    public InputButton ButtonLeft = InputButton.NONE;
    public InputButton ButtonBottom = InputButton.NONE;
    public InputButton ButtonRight = InputButton.NONE;
    public InputButton ButtonTop = InputButton.NONE;
    public InputButton Start = InputButton.NONE;
    public InputButton Select = InputButton.NONE;
    public InputButton Extra1 = InputButton.NONE;
    public InputButton Extra2 = InputButton.NONE;
    public InputButton Extra3 = InputButton.NONE;
    public InputButton Extra4 = InputButton.NONE;
    public InputButton Extra5 = InputButton.NONE;
    public InputButton Extra6 = InputButton.NONE;
    public InputButton Extra7 = InputButton.NONE;
    public InputButton Extra8 = InputButton.NONE;
    public InputButton Extra9 = InputButton.NONE;
    public InputButton Extra10 = InputButton.NONE;
    public InputButton Extra11 = InputButton.NONE;
}

