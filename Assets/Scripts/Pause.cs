using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{ 
    public GameObject pauseMenuUI;
    public bool isPaused;
    
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }

        if(isPaused){
            ActivateMenu();
            Time.timeScale = 0;
        }
        else
        {
            DeactivateMenu();
            Time.timeScale = 1;
        }

    }

    void ActivateMenu()
    {
        pauseMenuUI.SetActive(true);
    }

    public void DeactivateMenu()
    {
        pauseMenuUI.SetActive(false);
    }
}
