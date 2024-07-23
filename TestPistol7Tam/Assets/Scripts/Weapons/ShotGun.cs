using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotGun : WeaponClass
{

    public override void Shoot()
    {
        base.Shoot();
    }

    public override void InstanciateBullet(InteractableObject interactableObject)
    {
        System.Random random = new System.Random();
        for (int i = 0; i < amountOfBullets; i++)
        {
            GameObject newProjectile = Instantiate(bullet, gameObject.transform.position, Quaternion.identity);
            newProjectile.GetComponent<Rigidbody2D>().velocity = (interactableObject.transform.position + interactableObject.GetComponent<BoxCollider2D>().bounds.size / 2 + new Vector3(random.Next(-1, 2), random.Next(-1, 2), 0) - gameObject.transform.position) * bulletSpeed;
        }

    }
}
