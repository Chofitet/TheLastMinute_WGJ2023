using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FadeOutBlackBeteewnScenes : MonoBehaviour
{
    [SerializeField] Image Overley;
    private bool isfade;

    private void Start()
    {
        Overley.gameObject.SetActive(true);
        SoundManager.SM.PuertaAbriendose();
        SceneController.SceneM.SaveLastScene();
        Invoke("Fade", 4);
    }

    private void Update()
    {
        if(isfade)
        {
            var tempColor = Overley.color;
            tempColor.a -= Time.deltaTime * 0.5f;
            Overley.color = tempColor;
        }
    }
    void Fade()
    {
        isfade = true;
    }

}
