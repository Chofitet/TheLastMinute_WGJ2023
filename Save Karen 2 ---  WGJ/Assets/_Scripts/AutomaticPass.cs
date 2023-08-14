using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class AutomaticPass : MonoBehaviour
{
    [SerializeField] string Scene;
    [SerializeField] AudioClip NextAudio;

    private void OnEnable()
    {
        Invoke("Change", 1.5f);
    }
    void ChangeAudio()
    {
        if (NextAudio != null)
        {
            SoundManager.SM.FadeMusic(NextAudio);
        }
    }

    private void Change()
    {
        ChangeAudio();
        SceneManager.LoadScene(Scene);
    }
}
