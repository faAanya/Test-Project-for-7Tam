using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Unity.RemoteConfig;



public interface ISetRemoteConfigVariables
{
    void SetRemoteConfigVariables(ConfigResponse response);
};
public class RemoteConfigManager : MonoBehaviour, ISetRemoteConfigVariables
{

    public static RemoteConfigManager Instance;
    public struct userAttributes { };
    public struct appAttributes { };


    public void Awake()
    {

        ConfigManager.FetchConfigs<userAttributes, appAttributes>(new userAttributes(), new appAttributes());

    }

    public void SetRemoteConfigVariables(ConfigResponse response)
    {
        throw new System.NotImplementedException();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            ConfigManager.FetchConfigs<userAttributes, appAttributes>(new userAttributes(), new appAttributes());

        }
    }
}
