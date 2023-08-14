using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaFuerteZoom : MonoBehaviour
{
    public GameObject CajaFuerteObject;
    public GameObject roomController;
    public AudioSource audioSource; // AudioSource para reproducir los sonidos

    private void Start()
    {
        CajaFuerteObject.SetActive(false);
        gameObject.SetActive(false);

    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            MouseRightClick();
        }
    }

    void OnMouseDown()
    {
            //imprimir en consola que se hizo click
            Debug.Log("Click");
            CajaFuerteObject.SetActive(true);
            CajaFuerteObject.GetComponent<SpriteRenderer>().enabled = true;
            //desactivar los coliders de los objetos con el tag Habitacion
            foreach (GameObject zoomObject in GameObject.FindGameObjectsWithTag("Habitacion"))
            {
                zoomObject.GetComponent<Collider2D>().enabled = false;
            }
            
            if (CajaFuerteObject.GetComponent<Caja_Fuerte>().open == false)
            {
                CajaFuerteObject.GetComponent<Caja_Fuerte>().resetear(0f);
            }
            roomController.GetComponent<RoomController>().isZoomed = true;
    }

    private void MouseRightClick()
    {
        if (CajaFuerteObject.GetComponent<SpriteRenderer>().enabled && roomController.GetComponent<RoomController>().isZoomed == true)  
        {
            roomController.GetComponent<RoomController>().isZoomed = false;
            CajaFuerteObject.GetComponent<Renderer>().enabled = false;
            if (CajaFuerteObject.GetComponent<Caja_Fuerte>().open == false)
            {
                CajaFuerteObject.GetComponent<Caja_Fuerte>().resetear(0f);
            }
            //activar los coliders de los objetos con el tag Habitacion
            GameObject[] zoomObjects = GameObject.FindGameObjectsWithTag("Habitacion");
            foreach (GameObject zoomObject in zoomObjects)
            {
                zoomObject.GetComponent<Collider2D>().enabled = true;
            }
            CajaFuerteObject.SetActive(false);
        }
    }
}