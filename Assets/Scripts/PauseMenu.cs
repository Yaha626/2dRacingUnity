using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public bool PauseGame;

    public GameObject PauseGameMenu;

    [SerializeField] GameObject _mainMenu;

    [SerializeField] GameObject _garageMenu;





    void Update()
    {
/*
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (PauseGame)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
*/

    }


    public void Resume()
    {
        PauseGameMenu.SetActive(false);
        Time.timeScale = 1f;
        PauseGame = false;
    }


    public void Pause()
    {
        PauseGameMenu.SetActive(true);
        Time.timeScale = 0f;
        PauseGame = true;
    }


    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void LoadGarage()
    {
        Time.timeScale = 1f;       
        SceneManager.LoadScene("Menu");
        //_mainMenu.SetActive(false);
        //_garageMenu.SetActive(true);
    }

    public void LoadLevel()
    {
        SceneManager.LoadScene("Lavel_1_1");
    }
}
