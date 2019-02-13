using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockBack : MonoBehaviour
{
    public static event System.Action EventKnockBack;
    public float knockBackPower = 5;

    private void Start()
    {
        Shooting.EventBulletShooted += MakeKnockBack;
    }

    private void MakeKnockBack()
    {
        transform.position += -transform.right * knockBackPower * Time.deltaTime;
        EventKnockBack?.Invoke();
    }

}
