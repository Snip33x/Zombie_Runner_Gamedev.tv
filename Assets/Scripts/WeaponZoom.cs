using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponZoom : MonoBehaviour
{
    Camera fpsCamera;
    bool zoomedInToggle;
    [SerializeField] float zoomedOutFOV = 60f;
    [SerializeField] float zoomedInFOV = 20f;


    private void Start()
    {
        fpsCamera = FindObjectOfType<Camera>();
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            if(zoomedInToggle == false)
            {
                zoomedInToggle = true;
                fpsCamera.fieldOfView = zoomedInFOV;
            }
            else
            {
                zoomedInToggle = false;
                fpsCamera.fieldOfView = zoomedOutFOV;
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
