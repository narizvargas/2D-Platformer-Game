using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject pauseScreen;

    public void QuitGame()
    {
        Application.Quit();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(pauseScreen.activeInHierarchy)
                PauseGame(false);
            else
                PauseGame(true);
        }
    }

    #region Pause
    private void PauseGame(bool status)
    {
        pauseScreen.SetActive(status);
    }
    #endregion
}