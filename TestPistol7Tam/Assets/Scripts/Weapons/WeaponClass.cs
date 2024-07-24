using System.Collections;
using System.Collections.Generic;
using Unity.RemoteConfig;
using UnityEngine;
public class WeaponClass : MonoBehaviour, WeaponInterface, ISetRemoteConfigVariables
{

    public WeaponSO weaponInfo;
    public virtual void Awake()
    {
        ConfigManager.FetchCompleted += SetRemoteConfigVariables;
        RemoteConfigManager.Instance.Awake();
        weaponInfo.player = GameObject.FindGameObjectWithTag("Player");
        weaponInfo.playerPosition = GameObject.FindGameObjectWithTag("Player").gameObject.transform.position;
    }

    public virtual void Shoot()
    {

        InteractableObject interactableObject = FindClosestInteractableObject();

        if (Vector3.Distance(interactableObject.transform.position, gameObject.transform.position) <= weaponInfo.weaponMaxDistance)
        {
            InstanciateBullet(interactableObject);
        }
    }

    public virtual void InstanciateBullet(InteractableObject interactableObject) { }

    public InteractableObject FindClosestInteractableObject() //looks for closest interactableObject
    {
        float distanceToClosestinteractableObject = Mathf.Infinity;
        InteractableObject closestinteractableObject = null;
        IEnumerable<InteractableObject> allEnemies = FindObjectsOfType<InteractableObject>();

        foreach (InteractableObject currentinteractableObject in allEnemies)
        {
            float distanceTointeractableObject = (currentinteractableObject.transform.position - this.transform.position).sqrMagnitude;
            if (distanceTointeractableObject < distanceToClosestinteractableObject)
            {
                distanceToClosestinteractableObject = distanceTointeractableObject;
                closestinteractableObject = currentinteractableObject;
            }
        }
        return closestinteractableObject;

    }

    public void SetRemoteConfigVariables(ConfigResponse response)
    {
        weaponInfo.amountOfBullets = ConfigManager.appConfig.GetInt(weaponInfo.amountOfBulletsRC);
        weaponInfo.bulletSpeed = ConfigManager.appConfig.GetInt(weaponInfo.bulletSpeedRC);
        weaponInfo.weaponMaxDistance = ConfigManager.appConfig.GetInt(weaponInfo.weaponMaxDistanceRC);


        Debug.Log($"I set variables for {gameObject.name}");
    }
}
