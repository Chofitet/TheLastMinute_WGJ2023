using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllWires : MonoBehaviour
{
    [SerializeField] DragAndDrop wire1;
    [SerializeField] DragAndDrop wire2;
    [SerializeField] DragAndDrop wire3;
    [SerializeField] GameObject Activado;

    private void Update()
    {
        if(wire1.finish && wire2.finish && wire3.finish)
        {
            Debug.Log("asdasff");
            Activado.SetActive(true);
        }
    }
}
