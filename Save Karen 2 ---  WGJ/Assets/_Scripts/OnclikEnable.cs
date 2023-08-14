using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnclikEnable : MonoBehaviour
{
    [SerializeField] GameObject g;
    [SerializeField] DragAndDropFall DF;
    [SerializeField] DragAndDropFall DF1;
    [SerializeField] DragAndDropFall DF2;
    [SerializeField] DragAndDropFall DF3;
    [SerializeField] DragAndDropFall DF4;
    [SerializeField] DragAndDropFall DF5;
    private void OnMouseDown()
    {
        g.SetActive(true);
    }
    private void Update()
    {
        if(DF.finish && DF1.finish && DF2.finish && DF3.finish && DF4.finish && DF5.finish)
        {
            GetComponent<BoxCollider2D>().enabled = true;
        }
    }
}
