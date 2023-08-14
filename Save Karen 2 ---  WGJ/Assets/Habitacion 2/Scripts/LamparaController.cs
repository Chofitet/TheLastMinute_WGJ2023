using UnityEngine;

public class LamparaController : MonoBehaviour
{
    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); //Obtiene la posicion del mouse en el mundo
        mousePosition.z = 0f; //Fija la posicion en el eje z en 0
        transform.position = mousePosition; //Fija la posicion del objeto en la posicion del mouse
    }
}