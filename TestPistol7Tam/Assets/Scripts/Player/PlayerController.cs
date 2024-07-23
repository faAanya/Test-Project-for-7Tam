using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D), typeof(BoxCollider2D))]
public class PlayerController : MonoBehaviour
{

    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private FixedJoystick _joystick;

    [SerializeField] private float _moveSpeed;

    // Start is called before the first frame update
    void Start()
    {

    }

    void FixedUpdate()
    {
        MovePlayer();
    }


    void MovePlayer()
    {
        _rigidbody.velocity = new Vector2(_joystick.Horizontal * _moveSpeed, _joystick.Vertical * _moveSpeed);

        RotatePLayer();
    }
    void RotatePLayer()
    {
        // Vector2 Look = center.position - curScreenPosition;
        float angle = Mathf.Atan2(_joystick.Vertical, _joystick.Horizontal) * Mathf.Rad2Deg;

        if (_joystick.Horizontal != 0 && _joystick.Vertical != 0)
        {
            Quaternion target = Quaternion.Euler(0, 0, angle - 90f);
            transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * 5f);
        }
    }
}
