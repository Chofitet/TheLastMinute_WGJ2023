using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorBreaker : MonoBehaviour
{

    public bool isBroken = false; // Indica si el espejo está roto
    public AudioSource audioSource; // AudioSource para reproducir los sonidos
    public AudioClip breakSound; // Sonido a reproducir al romper el espejo
    public GameObject roomController; // Script de la habitación
    public GameObject zoomObject; // Objeto a mostrar al hacer zoom
    public bool zoom = false; // Indica si el objeto se puede ver al hacer zoom
    public bool breakeable = false; // Indica si el objeto se puede romper
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<SpriteRenderer>().enabled = false;
        zoomObject.GetComponent<SpriteRenderer>().enabled = false;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            MouseRightClick();
        }
    }
    void OnMouseDown()
    {
        if (!isBroken && breakeable && roomController.GetComponent<RoomController>().isZoomed == false)
        {
            BreakMirror();
        }

        else if (zoom && roomController.GetComponent<RoomController>().isZoomed == false && zoomObject.GetComponent<SpriteRenderer>().enabled == false)
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
    
    void BreakMirror()
    {
        isBroken = true;
        audioSource.PlayOneShot(breakSound);
        this.GetComponent<SpriteRenderer>().enabled = true;
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
