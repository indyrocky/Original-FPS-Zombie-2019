using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryCollectible : MonoBehaviour
{
    [SerializeField] float restoreAngle = 90f;
    [SerializeField] float addIntensity = 1f;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.GetComponentInChildren<FlashlightEffects>().RestoreLightAngle(restoreAngle);
            other.GetComponentInChildren<FlashlightEffects>().AddLightIntensity(addIntensity);
            Destroy(gameObject);
        }
    }
}
