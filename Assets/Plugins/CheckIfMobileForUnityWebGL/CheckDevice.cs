using TMPro;
using UnityEngine;


// Ovo su dll fajlovi koji nam omogucju provjeru je li koristimo mobitel ili pc
// ne treba ništa doradivat ovdje, provjera se radi na princip if(CheckDevice.instance.IsMobile() == true)
public class CheckDevice : MonoBehaviour
{
    public static CheckDevice instance;
    #if !UNITY_EDITOR && UNITY_WEBGL
    [System.Runtime.InteropServices.DllImport("__Internal")]
    private static extern bool IsMobile();
    #endif

    private void Awake() => instance = this;

	public static bool isMobile()
    {
        var isMobile = false;

        #if !UNITY_EDITOR && UNITY_WEBGL
            isMobile = IsMobile();
        #endif

        return isMobile;
    }
}
