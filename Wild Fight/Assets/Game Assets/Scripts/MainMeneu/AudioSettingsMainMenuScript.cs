using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioSettingsMainMenuScript : MonoBehaviour
{

    public AudioMixer audioMixer;
    public void setVolume(float volume)
    {
        audioMixer.SetFloat("AudioVolume", volume);
    }
}
