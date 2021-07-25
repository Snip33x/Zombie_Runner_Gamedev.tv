using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;


public class WeaponZoom : MonoBehaviour
{
    Camera fpsCamera;
    bool zoomedInToggle = false;
    [SerializeField] float zoomedOutFOV = 60f;
    [SerializeField] float zoomedInFOV = 20f;
    [SerializeField] float mouseSpeedOutFOV = 2f;
    [SerializeField] float mouseSpeedInFOV = 0.5f;

    RigidbodyFirstPersonController fpsController;

    private void Start()
    {
        fpsCamera = FindObjectOfType<Camera>();
        fpsController = GetComponent<RigidbodyFirstPersonController>();
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            if(zoomedInToggle == false)
            {
                zoomedInToggle = true;
                fpsCamera.fieldOfView = zoomedInFOV;
                fpsController.mouseLook.XSensitivity = mouseSpeedInFOV;
                fpsController.mouseLook.YSensitivity = mouseSpeedInFOV;
            }
            else
            {
                zoomedInToggle = false;
                fpsCamera.fieldOfView = zoomedOutFOV;
                fpsController.mouseLook.XSensitivity = mouseSpeedOutFOV;
                fpsController.mouseLook.YSensitivity = mouseSpeedOutFOV;
            }
        }
    }


    //My zooming code, working as expcted, but Rick's is simpler
    /*private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse1))  //Input.GetMouseButtonDown(1)
        {
            if (!zoomedInToggle)
                zoomedInToggle = true;
            else
                zoomedInToggle = false;
            zoom();
        }
    }

    void zoom()
    {
        if(zoomedInToggle)
        {
            fpsCamera.fieldOfView = zoomedInFOV;
        }
        if(!zoomedInToggle)
        {
            fpsCamera.fieldOfView = zoomedOutFOV;
        }
    }*/
}