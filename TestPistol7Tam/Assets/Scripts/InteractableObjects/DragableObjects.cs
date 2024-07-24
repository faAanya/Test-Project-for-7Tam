using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragableObjects : InteractableObject
{

    public override void Awake()
    {
        base.Awake();
    }
    public override void Interact(int damage)
    {
        base.Interact();
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(gameObject.transform.position.x - player.transform.position.x, (gameObject.transform.position.y - player.transform.position.y), 0f).normalized;

    }
}
