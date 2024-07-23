using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D bulletRB;
    Camera mainCam;
    [SerializeField] float maxBehindDistance = 0.5f;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<InteractableObject>() != null)
        {
            other.gameObject.GetComponent<InteractableObject>().Interact();
        }
        Destroy(gameObject);
    }
    void Update()
    {
        if (!gameObject.GetComponent<SpriteRenderer>().isVisible)
        {
            Destroy(this);
        }
    }
}