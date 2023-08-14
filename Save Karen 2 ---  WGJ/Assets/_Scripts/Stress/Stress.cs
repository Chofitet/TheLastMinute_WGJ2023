using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stress : MonoBehaviour
{
    public Slider sliderStress ;
    
    public virtual void ChangeMaxValue(int maxValue){
        sliderStress.maxValue=maxValue;
    }

    public virtual void UpdateInfo(int newValue){
        sliderStress.value=newValue;

       
    }



}
