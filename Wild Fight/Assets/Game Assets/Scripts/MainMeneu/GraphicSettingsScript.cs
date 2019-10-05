using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphicSettingsScript : MonoBehaviour
{
    public void SetQuality(int qualityIndex)
    {
        print("Quality Level: " + qualityIndex);
        QualitySettings.SetQualityLevel(qualityIndex);
    }
}
