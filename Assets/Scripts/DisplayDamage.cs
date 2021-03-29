using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayDamage : MonoBehaviour
{
    [SerializeField] Canvas playerDamageCanvas;
    [SerializeField] float canvasOnScreenTime = 0.3f;

    // Start is called before the first frame update
    void Start()
    {
        playerDamageCanvas.enabled = false;
    }

    public void ShowPlayerDamageCanvas()
    {
        StartCoroutine(ShowSplatter());
    }

    IEnumerator ShowSplatter()
    {
        playerDamageCanvas.enabled = true;
        yield return new WaitForSeconds(canvasOnScreenTime);
        playerDamageCanvas.enabled = false;
    }

  
}
