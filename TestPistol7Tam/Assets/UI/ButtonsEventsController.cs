using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsEventsController : MonoBehaviour
{
    public Button shootButton;
    public WeaponSwithcerController weaponSwithcerController;

    public Button[] weaponButton;

    void Awake()
    {
        weaponSwithcerController.GetComponent<WeaponSwithcerController>();
        foreach (Button weaponChangeButton in weaponButton)
        {
            weaponChangeButton.onClick.AddListener(() => { weaponSwithcerController.ChangeWeapon(weaponChangeButton.GetComponent<ButtonScript>().weaponHolder); });
        }

        weaponSwithcerController.GetComponent<WeaponSwithcerController>();
        shootButton.onClick.AddListener(() => { weaponSwithcerController.FindActiveWeapon().Shoot(); });
    }

}

