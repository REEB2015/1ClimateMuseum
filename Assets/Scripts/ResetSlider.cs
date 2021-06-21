using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetSlider : MonoBehaviour
{
    public void Reset(Slider slider)
    {
        int halfvalue = (int) slider.maxValue / 2;
        slider.value = halfvalue;
    }
}
