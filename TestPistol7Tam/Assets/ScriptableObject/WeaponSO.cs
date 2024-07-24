using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "WeaponSO", menuName = "Data/WeaponData/WeaponSo")]

public class WeaponSO : ScriptableObject
{
    public bool isActiveWeapon = true;
    public GameObject bullet;
    public int amountOfBullets;


    public int bulletSpeed;

    public int weaponMaxDistance;

    [HideInInspector]
    public Vector3 playerPosition;
    [HideInInspector]
    public GameObject player;

}
