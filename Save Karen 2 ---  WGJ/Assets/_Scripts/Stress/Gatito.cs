using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gatito : MonoBehaviour
{

    public struct Stat{
        public int currentValue ;
        public int maxValue;
    }

    public int estres;
    public const int MAX_Stress=100;

    public void AddStress(int newStress){
        estres +=newStress;
        if (estres>MAX_Stress){
            estres=MAX_Stress;
        }
        
    }
}
