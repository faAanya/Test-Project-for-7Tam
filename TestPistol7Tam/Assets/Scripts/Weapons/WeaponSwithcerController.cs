using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class WeaponSwithcerController : MonoBehaviour
{
    public static WeaponSwithcerController Instance;
    public WeaponClass[] weaponClasses;

    private WeaponClass currentWeapon, previousWeapon;
    void Awake()
    {
        currentWeapon = FindActiveWeapon();
    }

    public void ChangeWeapon(WeaponClass newWeapon)
    {
        previousWeapon = FindActiveWeapon();
        previousWeapon.weaponInfo.isActiveWeapon = false;
        newWeapon.weaponInfo.isActiveWeapon = true;
        currentWeapon = newWeapon;
    }

    public WeaponClass FindActiveWeapon()
    {
        var activeWeapon = System.Array.Find(weaponClasses, weapon => weapon.weaponInfo.isActiveWeapon);
        return activeWeapon;
    }


}
