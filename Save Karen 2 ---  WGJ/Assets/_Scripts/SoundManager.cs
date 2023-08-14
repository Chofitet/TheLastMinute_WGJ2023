using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager SM { get; private set;}
    public bool Fade { get; private set; }

    [SerializeField] GameObject _PuertaAbriendose;
    [SerializeField] GameObject _ValvulaCierre;

    private void Awake()
    {
        if (SM != null && SM != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            SM = this;
            DontDestroyOnLoad(SM);
        }
    }

    AudioClip AuxAudioClip;
     public void FadeMusic(AudioClip AC)
    {
        AuxAudioClip = AC;
        Fade = true;
    }

    void NewSound(GameObject prefabs, Vector3 posición, float duración = 5f, float ModificarPitch = 1)
    {
        GameObject obj = Instantiate(prefabs, posición, Quaternion.identity);
        obj.GetComponent<AudioSource>().pitch = ModificarPitch;
        Destroy(obj, duración);
    }

    public void ButtonSound(float ModificarPitch)
    {
       // NewSound(buttonSound, Camera.main.transform.position, 5, ModificarPitch);
    }
    public void PuertaAbriendose()
    {
        NewSound(_PuertaAbriendose, Camera.main.transform.position);
    }
    public void ValvulaCierre()
    {
        NewSound(_ValvulaCierre, Camera.main.transform.position);
    }

    private void Update()
    {
        AudioSource AS = GetComponent<AudioSource>();
        if (Fade)
        {
            AS.volume -= Time.deltaTime * 0.3f;
            if (AS.volume <= 0)
            {
                AS.clip = AuxAudioClip;
                AS.Play();
                AS.volume = 0.5F;
                Fade = false;
            }

        }
    }

}
