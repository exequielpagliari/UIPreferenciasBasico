using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

ErrorErrorError

public class DropTown : MonoBehaviour
{
    [SerializeField] TMP_Dropdown dropdown;
    [SerializeField] Resolution[] resolutions;
    [SerializeField] ResolutionController resolutionController;
    private void Start()
    {
        dropdown.onValueChanged.AddListener(delegate { OnDropdownChange(dropdown); });
        PopulateDropdown();
    }
    public void OnDropdownChange(TMP_Dropdown dropdown)
    {
        int menuIndex = dropdown.value;
        List<TMP_Dropdown.OptionData> menuOptions = dropdown.options;
        Debug.Log("Dropdown Current Value: " + menuIndex);
        resolutionController.ChangeResolution(menuIndex);


    }

    void PopulateDropdown()
    {
        // Lista de opciones para el Dropdown
        resolutions = resolutionController.TransferResolutions();
        List<string> options = new List<string>();
        foreach (Resolution resolution in  resolutions)
        {
            string s = "{0} x  {1}  @ {2} Hz";
            string s1 = string.Format(s, resolution.width, resolution.height, resolution.refreshRateRatio);
            options.Add(s1);
        }

        // Limpiar las opciones actuales del Dropdown
        dropdown.ClearOptions();

        // Agregar las nuevas opciones al Dropdown
        dropdown.AddOptions(options);
    }
}
