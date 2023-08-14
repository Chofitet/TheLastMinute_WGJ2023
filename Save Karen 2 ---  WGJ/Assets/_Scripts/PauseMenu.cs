using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    bool switcher;
    private void Start()
    {
        pauseMenu.SetActive(false);
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (switcher)
            {
                pauseMenu.SetActive(false);
                switcher = false;
                Time.timeScale = 1;
            }
            else
            {
                pauseMenu.SetActive(true);
                Time.timeScale = 0;
                switcher = true;
            }
        }
    }
    public void EnableMenu()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        switcher = false;
    }
}
