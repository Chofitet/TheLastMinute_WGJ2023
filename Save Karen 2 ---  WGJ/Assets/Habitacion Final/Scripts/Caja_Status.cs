using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Status : MonoBehaviour
{
    public GameObject cajaFuerte; // Objeto de la caja fuerte
    public Sprite sprite0; // Sprite para el estado 0
    public Sprite sprite1; // Sprite para el estado 1
    public Sprite sprite2; // Sprite para el estado 2

    private SpriteRenderer spriteRenderer; // Componente SpriteRenderer del objeto de la caja fuerte

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        int estado = cajaFuerte.GetComponent<Caja_Fuerte>().status; // Obtener el estado de la caja fuerte

        switch (estado)
        {
            case 0:
                spriteRenderer.sprite = sprite0;
                break;
            case 1:
                spriteRenderer.sprite = sprite1;
                break;
            case 2:
                spriteRenderer.sprite = sprite2;
                break;
            default:
                break;
        }
    }
}