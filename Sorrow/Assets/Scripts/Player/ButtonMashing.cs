using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class ButtonMashing : MonoBehaviour
{
    [HideInInspector] public float mashCount;
    public float mashMin;
    [SerializeField] float timeToLoose1MashProgress;
    [SerializeField] float fovIntencity;
    public CinemachineVirtualCamera buttonMashingVCam;
    [SerializeField] UnityEvent endActions;
    float minFov;

    void Awake() => mashCount = mashMin;

    void OnEnable()
    {
        minFov = buttonMashingVCam.m_Lens.FieldOfView;
        InputManager.controller.ButtonMashing.Enable();
        InputManager.controller.ButtonMashing.Button.performed += Mash;
    }

    void OnDisable()
    {
        InputManager.controller.ButtonMashing.Button.performed -= Mash;
        InputManager.controller.ButtonMashing.Disable();
    }

    void Mash(InputAction.CallbackContext _)
    {
        mashCount -= 1f;
        buttonMashingVCam.m_Lens.FieldOfView += fovIntencity;

        if (mashCount <= 0f)
            End();
    }

    void Update()
    {
        if (mashCount < mashMin)
            mashCount += Time.deltaTime / timeToLoose1MashProgress;
        if (mashCount > mashMin)
            mashCount = mashMin;
        if (buttonMashingVCam.m_Lens.FieldOfView > minFov)
            buttonMashingVCam.m_Lens.FieldOfView -= Time.deltaTime / timeToLoose1MashProgress * fovIntencity;
        if (buttonMashingVCam.m_Lens.FieldOfView < minFov)
            buttonMashingVCam.m_Lens.FieldOfView = minFov;
    }

    void End()
    {
        endActions.Invoke();
        enabled = false;
    }
}
