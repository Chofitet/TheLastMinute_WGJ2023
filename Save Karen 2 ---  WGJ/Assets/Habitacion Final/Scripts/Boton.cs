using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boton : MonoBehaviour
{
    public int valor = 0; // Valor del botón
    public GameObject cajaFuerte; // Objeto de la caja fuerte

private void OnMouseDown () {
        // Llamar al método AddDigit de la caja fuerte con el valor del botón
        cajaFuerte.GetComponent<Caja_Fuerte>().AddDigit(valor);
}
}