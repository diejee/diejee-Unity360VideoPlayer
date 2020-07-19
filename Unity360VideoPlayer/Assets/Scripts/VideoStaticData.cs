
using UnityEngine;

public class VideoStaticData : MonoBehaviour
{
    public static string VideoName;

    void Awake() 
    {
        DontDestroyOnLoad(this);
    }
}
