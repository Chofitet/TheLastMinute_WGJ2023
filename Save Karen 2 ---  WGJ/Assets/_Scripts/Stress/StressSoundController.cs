using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StressSoundController : MonoBehaviour
{
    AudioSource AS;
    Status2 Barra;

    [SerializeField] AudioClip Tranquilo;
    [SerializeField] AudioClip Estresado;

    private void Start()
    {
        AS = GetComponent<AudioSource>();
        Barra = GetComponent<Status2>();
    }

    private void Update()
    {
        if(Barra.gatito.estres > 64)
        {
            AS.clip = Estresado;
            AS.Play();
        }
        else
        {
            AS.clip = Tranquilo;
            AS.Play();
        }
    }


}
