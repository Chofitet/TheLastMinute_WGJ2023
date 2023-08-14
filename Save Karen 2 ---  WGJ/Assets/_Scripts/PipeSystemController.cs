using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSystemController : MonoBehaviour
{
   [SerializeField] PipeRotate[] pipes;
    int count;
    public void CheckRigth()
    {
       foreach(PipeRotate p in pipes)
        {
            if (!p.isRigth) return;

        }
        Debug.Log("correct");
        foreach (PipeRotate p in pipes)
        {
            Destroy(p);

        }
    }
}
