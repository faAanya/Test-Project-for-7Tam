using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagableObjects : InteractableObject
{
    [SerializeField]

    public override void Awake()
    {
        base.Awake();
    }
    public override void Interact(int damage)
    {
        base.Interact();
        if (health <= 0)
        {
            Die();
        }
        health -= damage;

    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
