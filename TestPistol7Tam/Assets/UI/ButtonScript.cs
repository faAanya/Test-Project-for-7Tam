using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public WeaponClass weaponHolder;
    private Button button;

    void Awake()
    {
        button = GetComponent<Button>();
    }
    void Update()
    {
        button.interactable = !weaponHolder.isActiveWeapon;
    }
}
