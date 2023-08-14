using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableRG : MonoBehaviour
{
    DragAndDropFall df;
    Rigidbody RB;
    private void Start()
    {
        df = GetComponent<DragAndDropFall>();
        RB = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if(df.finish)
        {
            RB.isKinematic = false;
            RB.constraints = RigidbodyConstraints.None;
            RB.constraints = RigidbodyConstraints.FreezePositionX;
            RB.constraints = RigidbodyConstraints.FreezePositionZ;
        }
    }
}
