using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootAnimTrigger : MonoBehaviour
{
    public string triggerNameForShoot;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        Shooting.EventBulletShooted += TriggerShootAnimation;
    }

    private void TriggerShootAnimation()
    {
        animator.Play(triggerNameForShoot, -1, 0);
    }
}
