using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{
    Transform player;
    float currXRotation;
    Rigidbody rb;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        player = transform.root;
        rb = player.GetComponent<Rigidbody>();
        currXRotation = transform.localRotation.eulerAngles.x;
    }

    void Update()
    {
        var delta = InputManager.controller.Camera.Look.ReadValue<Vector2>();
        float mouseY = delta.y * InputManager.instance.mouseSensitivity;
        float mouseX = delta.x * InputManager.instance.mouseSensitivity;

        if (mouseX != 0)
            rb.MoveRotation(rb.rotation * Quaternion.Euler(0f, mouseX, 0f));

        if (mouseY == 0)
            return;

        currXRotation -= mouseY;
        currXRotation = Mathf.Clamp(currXRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(currXRotation, 0, 0);
    }
}
