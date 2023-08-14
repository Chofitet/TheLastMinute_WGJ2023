using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PictureHidder : MonoBehaviour
{

    public bool isHidding = false; // Indica si la pintura está escondida
    public AudioSource audioSource; // AudioSource para reproducir los sonidos
    public AudioClip hideSound; // Sonido a reproducir al esconder la pintura
    void Start()
    {
        this.GetComponent<SpriteRenderer>().enabled = false;
    }

    void OnMouseDown()
    {
        if (!isHidding)
        {
            HidePicture();
        }
    }
    
    public void HidePicture()
    {
        isHidding = true;
        //Reproducir sonido de pintura escondiendose
        audioSource.PlayOneShot(hideSound);
        this.GetComponent<SpriteRenderer>().enabled = true;


    }
}
