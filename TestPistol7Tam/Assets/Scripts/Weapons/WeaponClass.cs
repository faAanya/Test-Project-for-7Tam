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

    public int weaponMaxDistance;

    private Vector3 playerPosition;
    private GameObject player;
    Vector2 range = new Vector2(-1, 1);
    public virtual void Awake()
    {
        player = GameObject.Find("Player");
        playerPosition = GameObject.FindGameObjectWithTag("Player").gameObject.transform.position;
    }

    void GunShot()
    {
        var fwd = gameObject.transform.forward;
        var up = gameObject.transform.up;

        System.Random random = new System.Random();

        var rot = Quaternion.AngleAxis(random.Next(45, 135), up);
        var rotatedVec = rot * fwd;
        var finalVec = rotatedVec * 12;
        transform.position = gameObject.transform.position + finalVec;
    }
    public virtual void Shoot()
    {

        InteractableObject interactableObject = FindClosestInteractableObject();

        if (Vector3.Distance(interactableObject.transform.position, gameObject.transform.position) <= weaponMaxDistance)
        {
            InstanciateBullet(interactableObject);
        }
    }

    public virtual void InstanciateBullet(InteractableObject interactableObject) { }

    public InteractableObject FindClosestInteractableObject() //looks for closest interactableObject
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
