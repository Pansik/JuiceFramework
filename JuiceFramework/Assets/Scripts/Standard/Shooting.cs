using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public static event System.Action EventBulletShooted;
    public GameObject bulletPrefab;
    public Transform shootPosition;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        GameObject newBullet = Instantiate(bulletPrefab, shootPosition.position, shootPosition.rotation);
        EventBulletShooted?.Invoke();
    }
}
