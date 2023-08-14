using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cuadro : MonoBehaviour
{
    public GameObject cajaObject;
    public AudioSource audioSource; // AudioSource para reproducir los sonidos
    public AudioClip hideSound; // Sonido a reproducir al esconder la pintura

    void OnMouseDown()
    {
        cajaObject.SetActive(true);
        audioSource.PlayOneShot(hideSound);
        Destroy(gameObject);
    }
}
