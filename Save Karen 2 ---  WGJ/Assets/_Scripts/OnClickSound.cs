using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickSound : MonoBehaviour
{
    [SerializeField] AudioClip AC;
    AudioSource AS;
    
    private void Start()
    {
        AS = GameObject.Find("audioSource").GetComponent<AudioSource>();
    }
    private void OnMouseDown()
    {
        AS.PlayOneShot(AC);
    }
}
