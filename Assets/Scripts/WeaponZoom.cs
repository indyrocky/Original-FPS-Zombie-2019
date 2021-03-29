using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera playerCamera;

    [SerializeField] RigidbodyFirstPersonController fpsController;

    [SerializeField] float zoomedOutFOV = 60f;
    [SerializeField] float zoomedinFOV = 20f;

    [SerializeField] float zoomOutSensitivity = 2f;
    [SerializeField] float zoomInSensitivity = 0.5f;

    bool zoomEnabled = false;


    private void OnDisable()
    {
        ZoomOut();
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (zoomEnabled == false)
            {
                ZoomIn();
            }

            else
            {
                ZoomOut();
            }
        }
    }

    private void ZoomOut()
    {
        zoomEnabled = false;
        playerCamera.fieldOfView = zoomedOutFOV;
        fpsController.mouseLook.XSensitivity = zoomOutSensitivity;
        fpsController.mouseLook.YSensitivity = zoomOutSensitivity;
    }

    private void ZoomIn()
    {
        zoomEnabled = true;
        playerCamera.fieldOfView = zoomedinFOV;
        fpsController.mouseLook.XSensitivity = zoomInSensitivity;
        fpsController.mouseLook.YSensitivity = zoomInSensitivity;
    }
}
