using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDropMultiply : MonoBehaviour
{
    public GameObject currentObject;
    public GameObject currentObject2;
    public GameObject currentObject3;
    bool moving;
    public bool finish;
    float startPosX;
    float startPosY;

    Vector3 ressetPos;

    private void Start()
    {
        ressetPos = this.transform.localPosition;

    }

    private void Update()
    {
        if (!finish)
        {
            if (moving)
            {
                Vector3 mousePos;
                mousePos = Input.mousePosition;
                mousePos = Camera.main.ScreenToWorldPoint(mousePos);

                this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, transform.localPosition.z);

            }
        }

    }
    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {

            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            startPosX = mousePos.x - transform.localPosition.x;
            startPosY = mousePos.y - transform.localPosition.y;
            moving = true;

        }
    }
    private void OnMouseUp()
    {
        moving = false;

        if (Mathf.Abs(transform.localPosition.x - currentObject.transform.localPosition.x) <= 0.5f &&
        Mathf.Abs(transform.localPosition.y - currentObject.transform.localPosition.y) <= 0.5f)
        {
            transform.position = new Vector3(currentObject.transform.position.x, currentObject.transform.position.y, currentObject.transform.position.z);
            finish = true;
            SoundManager.SM.ValvulaCierre();
        }
        else if (Mathf.Abs(transform.localPosition.x - currentObject2.transform.localPosition.x) <= 0.5f &&
        Mathf.Abs(transform.localPosition.y - currentObject2.transform.localPosition.y) <= 0.5f)
        {
            transform.position = new Vector3(currentObject2.transform.position.x, currentObject2.transform.position.y, currentObject2.transform.position.z);
            finish = true;
            SoundManager.SM.ValvulaCierre();
        }
        else if (Mathf.Abs(transform.localPosition.x - currentObject3.transform.localPosition.x) <= 0.5f &&
        Mathf.Abs(transform.localPosition.y - currentObject3.transform.localPosition.y) <= 0.5f)
        {
            transform.position = new Vector3(currentObject3.transform.position.x, currentObject3.transform.position.y, currentObject3.transform.position.z);
            finish = true;
            SoundManager.SM.ValvulaCierre();
        }
        else
        {
            transform.localPosition = new Vector3(ressetPos.x, ressetPos.y, ressetPos.z);
        }

    }
}
