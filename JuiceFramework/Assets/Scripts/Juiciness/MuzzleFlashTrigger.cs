using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuzzleFlashTrigger : MonoBehaviour
{
    public GameObject muzzleFlashLight;

    void Start()
    {
        Shooting.EventBulletShooted += DoMuzzleFlash;    
    }

    private void DoMuzzleFlash()
    {
        StartCoroutine(MuzzleFlash());
    }

    private IEnumerator MuzzleFlash()
    {
        muzzleFlashLight.SetActive(true);
        yield return new WaitForEndOfFrame();
        muzzleFlashLight.SetActive(false);
    }
}
