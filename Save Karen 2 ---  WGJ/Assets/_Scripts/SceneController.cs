using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public static SceneController SceneM { get; private set; }
    private void Awake()
    {

        if (SceneM != null && SceneM != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            SceneM = this;
            DontDestroyOnLoad(SceneM);
        }

    }
    string LastScene;
    public void SaveLastScene()
    {
        LastScene = SceneManager.GetActiveScene().name;

    }

    public void ChargeScene()
    {
        SceneManager.LoadScene(LastScene);
    }
}
