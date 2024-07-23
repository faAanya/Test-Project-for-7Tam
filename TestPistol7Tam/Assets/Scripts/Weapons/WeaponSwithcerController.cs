using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class WeaponSwithcerController : MonoBehaviour
{
    public static WeaponSwithcerController Instance;
    public WeaponClass[] weaponClasses;

    public WeaponClass FindActiveWeapon()
    {
        var activeWeapon = System.Array.Find(weaponClasses, weapon => weapon.isActiveWeapon);
        return activeWeapon;
    }


}
