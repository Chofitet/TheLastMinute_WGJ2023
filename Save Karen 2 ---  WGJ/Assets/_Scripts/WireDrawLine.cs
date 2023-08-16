using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireDrawLine : MonoBehaviour
{
    LineRenderer Line;
    DragAndDrop DD;
    bool Draggin;
    bool finiiish;

    Vector3 Pos1;
    private Vector3 Pos2;

    private void Start()
    {
       DD = GetComponent<DragAndDrop>();
        Line = GetComponent<LineRenderer>();
    }

    private void OnMouseDown()
    {
        Draggin = true;
        Pos1 = transform.position;
    }
   
    private void Update()
    {
        if (Draggin)
        {
            DrawLine(transform.position);
        }

    }
    private void OnMouseUp()
    {
        if (!DD.finish)
        {
            Invoke("aaa", 0.01f);
            Draggin = false;
        }
    }
    void DrawLine(Vector3 x)
    {
        if (DD.finish) return;
        Line.SetVertexCount(2);
        Pos2 = x;
        Pos1.z = 1;
        Pos2.z = 1;
        Vector3[] positions = { Pos1, Pos2 };
        Line.SetPositions(positions);
    }

    void aaa ()
    {
        DrawLine(Pos1);
    }
}

