using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryPickup : MonoBehaviour
{
    [SerializeField] float amountOfAngleRestore = 50f;
    [SerializeField] float amountOfLightIntensityRestore = 4f;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            //FindObjectOfType<FlashlightSystem>().RestoreLightAngle(amountOfAngleRestore);
            //FindObjectOfType<FlashlightSystem>().RestoreLightIntensity(amountOfLightIntensityRestore);
            other.GetComponentInChildren<FlashlightSystem>().RestoreLightAngle(amountOfAngleRestore);
            other.GetComponentInChildren<FlashlightSystem>().RestoreLightIntensity(amountOfLightIntensityRestore);
            Destroy(gameObject);

        }
    }
}
