using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class DropTown : MonoBehaviour
{
    [SerializeField] TMP_Dropdown dropdown;

    [SerializeField] ResolutionController resolutionController;
    private void Start()
    {
        dropdown.onValueChanged.AddListener(delegate { OnDropdownChange(dropdown); });
    }
    public void OnDropdownChange(TMP_Dropdown dropdown)
    {
        int menuIndex = dropdown.value;
        List<TMP_Dropdown.OptionData> menuOptions = dropdown.options;
        Debug.Log("Dropdown Current Value: " + menuIndex);

        switch (menuIndex)
        {
            case 0:
                resolutionController.Change480p();
                return;
            case 1:
                resolutionController.Change720p();
                return;
            case 2:
                resolutionController.Change900p();
                return;

        }
    }


}
