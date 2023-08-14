using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    public GameObject zoomObject;
    public GameObject roomController;

    private void Start()
    {
        zoomObject.GetComponent<SpriteRenderer>().enabled = false;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            MouseRightClick();
        }
    }
    private void OnMouseDown()
    {
        if (roomController.GetComponent<RoomController>().isZoomed == false && this.GetComponent<SpriteRenderer>().enabled == false)
        {
            GameObject[] zoomObjects = GameObject.FindGameObjectsWithTag("Zoom");

            foreach (GameObject zoomObject in zoomObjects)
            {
                zoomObject.GetComponent<SpriteRenderer>().enabled = false;
            }
            
            zoomObject.GetComponent<SpriteRenderer>().enabled = true;
            roomController.GetComponent<RoomController>().isZoomed = true;
            }
    }

    private void MouseRightClick()
    {
        if (zoomObject.GetComponent<SpriteRenderer>().enabled)
        {
            roomController.GetComponent<RoomController>().isZoomed = false;
            zoomObject.GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}
