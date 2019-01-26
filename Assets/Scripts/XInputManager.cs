using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using XboxCtrlrInput;

public class XInputManager : MonoBehaviour
{
    [SerializeField] XboxController m_controller;

    [SerializeField] UnityEvent m_A, m_B, m_X, m_Y;
    [SerializeField] UnityEventVector2 m_leftStick;

    // Update is called once per frame
    void Update()
    {
        if(XCI.GetButtonDown(XboxButton.A, m_controller))
            m_A.Invoke();

        if(XCI.GetButtonDown(XboxButton.B, m_controller))
            m_B.Invoke();

        if(XCI.GetButtonDown(XboxButton.X, m_controller))
            m_X.Invoke();

        if(XCI.GetButtonDown(XboxButton.Y, m_controller))
            m_Y.Invoke();

        m_leftStick.Invoke(new Vector2(XCI.GetAxis(XboxAxis.LeftStickX, m_controller), XCI.GetAxis(XboxAxis.LeftStickY, m_controller)));
    }
}
