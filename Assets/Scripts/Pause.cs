using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{ 
    public static Pause Instance;
    public GameObject pauseMenuUI;
    public bool isPaused;
    
    private void Start()
    {
        Instance = this;
        pauseMenuUI.SetActive(false);
    }

    public void Update()
    {
        if (GlobalScript.Instance.isGameOver == false)
        {
            if(Input.GetKeyDown(KeyCode.Escape)||Input.GetKeyDown(KeyCode.Space))
            {
                isPaused = !isPaused;
            
                if(isPaused){
                    ActivateMenu();
                }
                else
                {
                    DeactivateMenu();
                }
            }  
        }
    }

    public void ActivateMenu()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0;
        isPaused = true;
    }

    public void DeactivateMenu()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1;
        isPaused = false;
    }

    public void QuitGame(){
        Application.Quit();
        Debug.Log("Game is Exit");
    }

    public void ToMainMenu(){
        SceneManager.LoadScene("MenuScene");
        isPaused = false;
        Time.timeScale = 1;
    }
}