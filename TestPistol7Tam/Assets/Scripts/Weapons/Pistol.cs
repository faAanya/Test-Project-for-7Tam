using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : WeaponClass
{


    public override void Shoot()
    {
        base.Shoot();
    }

    public override void InstanciateBullet(InteractableObject interactableObject)
    {
        GameObject newProjectile = Instantiate(bullet, gameObject.transform.position, Quaternion.identity);
        newProjectile.GetComponent<Rigidbody2D>().velocity = (interactableObject.transform.position + interactableObject.GetComponent<BoxCollider2D>().bounds.size / 2 - gameObject.transform.position) * bulletSpeed;
    }
}
