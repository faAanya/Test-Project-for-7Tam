using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    [HideInInspector]
    public GameObject player;
    public int health;
    public virtual void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    public virtual void Interact()
    {
        Debug.Log("You hit me");
    }
    public virtual void Interact(int damage)
    {
        Debug.Log("You hit me");
    }

}
