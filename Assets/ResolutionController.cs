using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResolutionController : MonoBehaviour
{

    [SerializeField] Toggle toggle;
    [SerializeField] Resolution[] resolutions;


    private void Awake()
    {
        ReadResolutions();
    }

    // Start is called before the first frame update
    void Start()
    {
        
        toggle.isOn = true;
    }

    


    private void SetResolution(int width, int height, FullScreenMode fullscreen, RefreshRate preferredRefreshRate)
    {
        Screen.SetResolution(width, height, fullscreen, preferredRefreshRate);
    }


    private FullScreenMode ReadFullScreen()
    {
        if (toggle.isOn)
            return FullScreenMode.FullScreenWindow;
        else
            return FullScreenMode.Windowed;

    }

    private void ReadResolutions()
    {
        // Obtiene la lista de resoluciones soportadas
        resolutions = Screen.resolutions;

        // Muestra las resoluciones posibles
        foreach (Resolution resolution in resolutions)
        {
            Debug.Log(resolution.width + "x" + resolution.height + " @" + resolution.refreshRateRatio + "Hz");
        }
    }


    public void ChangeResolution(int posc)
    {
        Resolution resolution = resolutions[posc];
        SetResolution(resolution.width, resolution.height, ReadFullScreen(), resolution.refreshRateRatio);
    }

    public Resolution[] TransferResolutions()
    {
        return resolutions;
    }

}
