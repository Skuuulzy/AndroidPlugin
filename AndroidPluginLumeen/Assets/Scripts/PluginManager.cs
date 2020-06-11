using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PluginManager : MonoBehaviour
{
    private string _pluginName = "com.skuuulzy.androidlibrary.BasicCommands";

    private AndroidJavaClass _unityPlayerClass;
    private AndroidJavaObject _unityActivity;

    private AndroidJavaObject _basicCommands;

    private AndroidJavaObject _vibrator;

    public string[] toastMessages;

    //The vibration time in miliseconds
    public long vibrationTime = 400;

    private void Start()
    {
        //Get the current activity with the unity player class
        _unityPlayerClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        _unityActivity = _unityPlayerClass.GetStatic<AndroidJavaObject>("currentActivity");

        //Get the class created into the library
        _basicCommands = new AndroidJavaObject(_pluginName);

        //Get the vibrator
        _vibrator = _unityActivity.Call<AndroidJavaObject>("getSystemService", "vibrator");
    }   

    public void ShowToast()
    {
        string toastMessage = toastMessages[Random.Range(0, toastMessages.Length)];
        _basicCommands.Call("ShowToast", _unityActivity,toastMessage);
    }

    public void Vibrate()
    {
        _basicCommands.Call("Vibrate",_vibrator, vibrationTime);
    }
}