using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D bulletRB;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<InteractableObject>() != null)
        {
            other.gameObject.GetComponent<InteractableObject>().Interact();
        }
        Destroy(this);
    }
}