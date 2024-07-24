using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Unity.RemoteConfig;
public class WeaponSwithcerController : MonoBehaviour
{
    public static WeaponSwithcerController Instance;
    public WeaponClass[] weaponClasses;

    private WeaponClass currentWeapon, previousWeapon;
    void Awake()
    {
        if (FindActiveWeapon() != null)
        {
            currentWeapon = FindActiveWeapon();
        }
    }

    public void ChangeWeapon(WeaponClass newWeapon)
    {
        if (FindActiveWeapon() != null)
        {
            previousWeapon = FindActiveWeapon();
            previousWeapon.weaponInfo.isActiveWeapon = false;
            newWeapon.weaponInfo.isActiveWeapon = true;
            currentWeapon = newWeapon;
        }
        else
        {
            newWeapon.weaponInfo.isActiveWeapon = true;
            currentWeapon = newWeapon;
        }
    }

    public WeaponClass FindActiveWeapon()
    {
        var activeWeapon = System.Array.Find(weaponClasses, weapon => weapon.weaponInfo.isActiveWeapon);
        return activeWeapon;
    }


}
