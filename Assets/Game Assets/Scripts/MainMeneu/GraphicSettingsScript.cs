using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphicSettingsScript : MonoBehaviour
{
    public void SetQuality(int qualityIndex)
    {
        print(qualityIndex);
        QualitySettings.SetQualityLevel(qualityIndex);
    }
}
