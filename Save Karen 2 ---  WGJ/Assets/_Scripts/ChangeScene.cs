using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ChangeScene : MonoBehaviour
{
    [SerializeField] string Scene;
    [SerializeField] AudioClip NextAudio;
    
    public bool Fade { get; private set; }

    public void OnClick ()
    {
        SceneManager.LoadScene(Scene);
        ChangeAudio();
    }
    
    public void QuitGame ()
    {
        Application.Quit();
    }

    private void OnMouseDown()
    {
        SceneManager.LoadScene(Scene);
        ChangeAudio();
    }

    void ChangeAudio()
    {
        if (NextAudio != null)
        {
            SoundManager.SM.FadeMusic(NextAudio);
        }
    }

}
