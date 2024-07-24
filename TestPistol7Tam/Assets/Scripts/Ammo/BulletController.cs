using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D bulletRB;
    [SerializeField] private Sprite collistionSprite;
    public int damage;
    Camera mainCam;

    private Vector3 startPosition;
    private WeaponSwithcerController weaponSwithcerController;
    void Awake()
    {
        weaponSwithcerController = GameObject.FindGameObjectWithTag("WeaponSwitcherController").GetComponent<WeaponSwithcerController>();
        startPosition = transform.position;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<InteractableObject>() != null)
        {
            other.gameObject.GetComponent<InteractableObject>().Interact(damage);
        }
        Destroy(gameObject);
    }
    void Update()
    {
        if (!gameObject.GetComponent<SpriteRenderer>().isVisible || Vector2.Distance(startPosition, gameObject.transform.position) >= weaponSwithcerController.FindActiveWeapon().weaponInfo.weaponMaxDistance)
        {
            Destroy(gameObject);
        }
    }
}