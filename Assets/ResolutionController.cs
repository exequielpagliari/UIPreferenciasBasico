using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResolutionController : MonoBehaviour
{

    [SerializeField] Toggle toggle;
    
    // Start is called before the first frame update
    void Start()
    {

        toggle.isOn = true;
    }

    


    private void SetResolution(int width, int height, bool fullscreen)
    {
        Screen.SetResolution(width, height, fullscreen);
    }


    public void Change480p()
    {
        SetResolution(640, 480, toggle.isOn);
    }

    public void Change720p()
    {
        SetResolution(1280, 720, toggle.isOn);
    }

    public void Change900p()
    {
        SetResolution(1600, 900, toggle.isOn);
    }






}
