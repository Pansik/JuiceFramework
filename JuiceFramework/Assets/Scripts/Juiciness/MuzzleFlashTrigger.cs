using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuzzleFlashTrigger : MonoBehaviour
{
    public GameObject muzzleFlashLight;
    public float minOffset = 0.05f;
    public float maxOffset = 0.1f;
    public float maxIntensity = 6.5f;
    public float minIntensity = 4.5f;
    public float maxRange = 2f;
    public float minRange = 1.2f;

    private Vector3 originalPosition;

    void Start()
    {
        originalPosition = muzzleFlashLight.transform.position;
        Shooting.EventBulletShooted += DoMuzzleFlash;    
    }

    private void DoMuzzleFlash()
    {
        StartCoroutine(MuzzleFlash());
    }

    private IEnumerator MuzzleFlash()
    {
        RandomizePosition();
        RandomizeIntensity();
        RandomizeRange();
        muzzleFlashLight.SetActive(true);
        yield return new WaitForEndOfFrame();
        muzzleFlashLight.SetActive(false);
        muzzleFlashLight.transform.position = originalPosition;
    }

    private void RandomizePosition()
    {
        muzzleFlashLight.transform.position = new Vector3(
            muzzleFlashLight.transform.position.x,
            muzzleFlashLight.transform.position.y + Random.Range(minOffset, maxOffset),
            +muzzleFlashLight.transform.position.z + Random.Range(minOffset, maxOffset));
    }

    private void RandomizeIntensity()
    {
        muzzleFlashLight.GetComponent<Light>().intensity = Random.Range(minIntensity, maxIntensity);
    }

    private void RandomizeRange()
    {
        muzzleFlashLight.GetComponent<Light>().range = Random.Range(maxRange, minRange);
    }
}
