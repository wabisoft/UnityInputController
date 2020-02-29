using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(InputController))]
[ExecuteInEditMode]
public class InputTest : MonoBehaviour
{
    public const int numAxes = 28;
    public const int numButtons = 20;
    public bool testAxes = true;
    public bool testButtons = true;
    public bool[] Axes = new bool[numAxes];
    public bool[] Buttons = new bool[numButtons];
    private InputController inputController;

    void Start() {
        inputController = inputController ?? GetComponent<InputController>();
        Debug.Assert(inputController != null);
    }

    void Update() {
        var name = inputController.Number.ToString();
        if (testAxes) {
            for (int i = 0; i < numAxes; ++i) {
                if (Axes[i]) {
                    var axisName = $"{name}A{i}";
                    var axis = Input.GetAxis(axisName);
                    if (axis != 0) {
                        Debug.Log($"A{i}: {axis}");
                    }
                }
            }
        }
        if (testButtons) {
            for (int i = 0; i < numButtons; ++i) {
                if (Buttons[i]) {
                    var buttonName = $"{name}B{i}";
                    if (Input.GetButtonDown(buttonName)) {
                        Debug.Log(buttonName);
                    }
                }
            }
        }
    }
}
