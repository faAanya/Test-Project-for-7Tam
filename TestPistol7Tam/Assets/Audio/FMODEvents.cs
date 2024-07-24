using UnityEngine;

public class FMODEvents : MonoBehaviour
{
    public static FMODEvents Instance { get; private set; }
    // [field: Header("UI SFX")]
    // [field: SerializeField] public EventReference equiptionSound { get; private set; }

    // [field: Header("Blends SFX")]

    // [field: Header("UI SFX")]
    // [field: SerializeField] public EventReference buttonClick { get; private set; }
    // [field: Header("Music")]



    //[field: SerializeField] public EventReference ambient { get; private set; }

    private void Awake()
    {
        DontDestroyOnLoad(this);

        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

    }

}
