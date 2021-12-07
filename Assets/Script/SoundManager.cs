using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource soundSetting;

    public void SettingSound(float volume)
    {
        soundSetting.volume = volume;
    }
}
