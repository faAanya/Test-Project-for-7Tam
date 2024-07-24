using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : WeaponClass
{

    public override void Awake()
    {
        base.Awake();
    }

    public override void Shoot()
    {
        base.Shoot();
    }

    public override void InstanciateBullet(InteractableObject interactableObject)
    {
        GameObject newProjectile = Instantiate(weaponInfo.bullet, gameObject.transform.position, Quaternion.identity);
        newProjectile.GetComponent<Rigidbody2D>().velocity = (interactableObject.transform.position - gameObject.transform.position) * weaponInfo.bulletSpeed;
    }
}
