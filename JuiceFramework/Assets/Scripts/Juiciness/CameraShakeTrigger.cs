using EZCameraShake;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShakeTrigger : MonoBehaviour
{
    public float magnitude = 4f;
    public float roughness = 4f;
    public float fadeInTime = 0.1f;
    public float fadeOutTime = 1f;

    private void Awake()
    {
        Shooting.EventBulletShooted += DoShake;
    }

    private void DoShake()
    {
        CameraShaker.Instance.ShakeOnce(magnitude, roughness, fadeInTime, fadeOutTime);
    }
}
