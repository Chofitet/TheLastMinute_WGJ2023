using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDropFall : MonoBehaviour
{
    bool moving;
    public bool finish;

    Vector3 ressetPos;

    private void Start()
    {
        ressetPos = this.transform.localPosition;

    }

    private void Update()
    {
            if (moving)
            {
                Vector3 mousePos;
                mousePos = Input.mousePosition;
                mousePos = Camera.main.ScreenToWorldPoint(mousePos);
                mousePos.z = 5;
                this.gameObject.transform.localPosition = mousePos;

            }

    }
    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {

            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            moving = true;

        }
    }
    private void OnMouseUp()
    {
        moving = false;
        finish = true;

    }
}
