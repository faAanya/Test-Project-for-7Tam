using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponClass : MonoBehaviour, WeaponInterface
{

    public bool isActiveWeapon = true;
    public GameObject bullet;
    public int amountOfBullets;

    public int damage;

    public int bulletSpeed;

    public virtual void Shoot()
    {
        InteractableObject interactableObject = FindClosestInteractableObject();
        GameObject newProjectile = Instantiate(bullet, gameObject.transform.position, Quaternion.identity);
        newProjectile.GetComponent<Rigidbody2D>().velocity = (interactableObject.transform.position + interactableObject.GetComponent<BoxCollider2D>().bounds.size / 2 - gameObject.transform.position) * bulletSpeed;

        // interactableObject.transform.rotation

        // GameObject.FindGameObjectWithTag("Player").transform.rotation = Quaternion.Euler();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1) && isActiveWeapon)
        {
            Shoot();
        }
    }

    public void ShootToClosetEnemy()
    {

    }

    InteractableObject FindClosestInteractableObject() //looks for closest interactableObject
    {
        float distanceToClosestinteractableObject = Mathf.Infinity;
        InteractableObject closestinteractableObject = null;
        IEnumerable<InteractableObject> allEnemies = FindObjectsOfType<InteractableObject>();

        foreach (InteractableObject currentinteractableObject in allEnemies)
        {
            float distanceTointeractableObject = (currentinteractableObject.transform.position - this.transform.position).sqrMagnitude;
            if (distanceTointeractableObject < distanceToClosestinteractableObject)
            {
                distanceToClosestinteractableObject = distanceTointeractableObject;
                closestinteractableObject = currentinteractableObject;
            }
        }
        return closestinteractableObject;

    }
}
