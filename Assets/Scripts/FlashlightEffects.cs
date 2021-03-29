using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightEffects : MonoBehaviour
{
    [SerializeField] float lightLoss = .1f;
    [SerializeField] float angleLoss = 1f;
    [SerializeField] float minimumAngle = 40f;

    Light myLight;
    
    // Start is called before the first frame update
    void Start()
    {
        myLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        DecreaseLightAngle();
        DecreaseLightIntensity();
    }

    public void RestoreLightAngle(float restoreAngle)
    {
        myLight.spotAngle = restoreAngle;
    }

    public void AddLightIntensity(float intensityAmount)
    {
        myLight.intensity += intensityAmount;
    }

    void DecreaseLightAngle()
    {

        if (myLight.spotAngle <= minimumAngle)
        {
            return;
        }

        else
        {
            myLight.spotAngle -= angleLoss * Time.deltaTime;
        }
    }
    
    void DecreaseLightIntensity()
    {
        myLight.intensity -= lightLoss * Time.deltaTime;
    }
}
