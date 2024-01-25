using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundModule : MonoBehaviour
{
    [SerializeField]
    AudioMixer mixer;

    [SerializeField]
    Slider Sound;

    [SerializeField]
    Slider Music;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SoundExposed(float value) // 1
    {
        mixer.SetFloat("Sound", value);
        //mixer.SetFloat("SFXVolume", value); // 3
        Debug.Log(value);
    }



    public void MusicExposed(float value) // 1
    {
        mixer.SetFloat("Music", value); // 3
    }
}
