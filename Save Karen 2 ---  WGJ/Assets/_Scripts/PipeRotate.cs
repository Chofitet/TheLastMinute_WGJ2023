using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeRotate : MonoBehaviour
{
    public bool isRigth;
    [SerializeField] float RigthPos;
    [SerializeField] float AnotherRigthPos = 1;
    PipeSystemController Controller;
    private void Start()
    {
        Controller = GetComponentInParent<PipeSystemController>();
        Comprobation();
    }
    private void OnMouseDown()
    {
        transform.Rotate(new Vector3(0, 0, 90));
        Comprobation();


    }
    void Comprobation()
    {
        if (RigthPos == transform.localRotation.eulerAngles.z || AnotherRigthPos == transform.localRotation.eulerAngles.z)
        {
            isRigth = true;
        }
        else isRigth = false;

        Controller.CheckRigth();
    }

}
