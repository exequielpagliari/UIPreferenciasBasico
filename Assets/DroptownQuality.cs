using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DroptownQuality : MonoBehaviour
{
    [SerializeField] TMP_Dropdown dropdown;

    [SerializeField] QualityController qualityController;
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
                qualityController.QualityLow();
                return;
            case 1:
                qualityController.QualityMedium();
                return;
            case 2:
                qualityController.QualityHigh();
                return;

        }
    }
}
