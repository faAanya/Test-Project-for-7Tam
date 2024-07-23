using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsEventsController : MonoBehaviour
{
    public Button shootButton;
    public WeaponSwithcerController weaponSwithcerController;

    void Awake()
    {
        weaponSwithcerController.GetComponent<WeaponSwithcerController>();
        shootButton.onClick.AddListener(() => { weaponSwithcerController.FindActiveWeapon().Shoot(); });
    }

}

