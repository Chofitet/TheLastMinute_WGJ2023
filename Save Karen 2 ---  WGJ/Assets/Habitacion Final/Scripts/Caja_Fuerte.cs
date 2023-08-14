using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Caja_Fuerte : MonoBehaviour
{
    public bool open = false; // Indica si la caja fuerte está abierta
    public int[] password = {1, 2, 3, 4}; // Contraseña de ejemplo
    public int status = 0; // Estado de la caja fuerte. 0 = cerrada, 1 = abierta 2 = error
    private int[] input = new int[4]; // Array para almacenar los dígitos ingresados por el usuario
    private int inputIndex = 0; // Índice para saber en qué posición del array se debe agregar el siguiente dígito
    public AudioClip buttonSound; // Sonido a reproducir al presionar un botón
    public AudioClip openSound; // Sonido a reproducir al abrir la caja fuerte
    public AudioClip errorSound; // Sonido a reproducir al ingresar una contraseña incorrecta
    public AudioSource audioSource; // AudioSource para reproducir los sonidos
    public Sprite openImage; // Imagen para mostrar la caja fuerte abierta
    public Sprite openImageFar; // Imagen para mostrar la caja fuerte abierta en la vista lejana
    public GameObject Objects; // GameObject para almacenar los objetos que se encuentran dentro de la caja fuerte
    public GameObject cajaFar; // GameObject para almacenar la caja fuerte en la vista lejana
    public Text display; // Texto para mostrar el estado de la caja fuerte

    public void Start()
    {
        Objects.SetActive(false);
        gameObject.SetActive(false);
    }
    public void AddDigit(int digit)
    {
        if (inputIndex < 4 && !open && status != 2) // Verificar que no se haya ingresado la contraseña completa y que la caja fuerte no esté abierta 
        {
            input[inputIndex] = digit; // Agregar el dígito al array
            inputIndex++; // Incrementar el índice
            audioSource.PlayOneShot(buttonSound); // Reproducir el sonido
            display.text = input[0].ToString() + input[1].ToString() + input[2].ToString() + input[3].ToString(); // Actualizar el texto
            if (inputIndex == 4)
            {
                if (CheckPassword()) // Verificar si la contraseña es correcta
                {
                    Abrir();
                }
                else
                {
                    Error();
                }
            }
        }
    }

    bool CheckPassword()
    {
        for (int i = 0; i < 4; i++)
        {
            if (input[i] != password[i])
            {
                return false;
            }
        }
        return true;
    }

    void Abrir()
    {
        audioSource.PlayOneShot(openSound);
        open = true; 
        status = 1;
        //Esperar 1.5 segundos, luego llamar al metodo AbrirPuerta
        StartCoroutine(AbrirPuerta(1.5f));
    }
    
    IEnumerator AbrirPuerta(float delay)
    {
        yield return new WaitForSeconds(delay);
        //eliminar Caja fuerte Status, botones, y texto
        Destroy(GameObject.Find("CF_Status"));
        Destroy(GameObject.Find("Botones"));
        Destroy(GameObject.Find("Display"));
        //Cambiar la imagen de la puerta a abierta
        GetComponent<SpriteRenderer>().sprite = openImage;
        cajaFar.GetComponent<SpriteRenderer>().sprite = openImageFar;
        //Activar los objetos que estan dentro de la caja fuerte
        Objects.SetActive(true);
    }

    public void resetear(float delay)
    {
        StartCoroutine(ResetearInput(delay));
    }
    void Error()
    {
        audioSource.PlayOneShot(errorSound);
        inputIndex = 0; 
        status = 2;
        StartCoroutine(ResetearInput(1.5f));
    }

    IEnumerator ResetearInput(float delay)
    {
        yield return new WaitForSeconds(delay);
        for (int i = 0; i < 4; i++)
        {
            input[i] = 0;
        }
        inputIndex = 0;
        display.text = input[0].ToString() + input[1].ToString() + input[2].ToString() + input[3].ToString();
        status = 0;
    }
}