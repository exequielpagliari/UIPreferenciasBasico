using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QualityController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SetQualityLevel(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void QualityLow() 
    {
        SetQualityLevel(1);
    }

    public void QualityMedium()
    {
        SetQualityLevel(2);
    }

    public void QualityHigh()
    {
        SetQualityLevel(3);
    }
}
