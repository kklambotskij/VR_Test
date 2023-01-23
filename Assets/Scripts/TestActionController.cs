using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class TestActionController : MonoBehaviour
{
    private ActionBasedController _controller;

    // Start is called before the first frame update
    void Start()
    {
        _controller = GetComponent<ActionBasedController>();
        bool isPressed = _controller.selectAction.action.ReadValue<bool>();
        _controller.selectAction.action.performed += ActionOnperformed;
    }

    private void ActionOnperformed(InputAction.CallbackContext obj)
    {
        Debug.Log("Select Button is Pressed");
    }

    // Update is called once per frame
    void Update()
    {
    }
}