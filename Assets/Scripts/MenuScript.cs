using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    int index = 0;
    public int totalMenu = 3;
    public float yOffset = 3f;
   
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown (KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            if (index < totalMenu -1)
            {
                index++;
                Vector2 position = transform.position;
                position.y -= yOffset;
                transform.position = position;
            }
        }

        if (Input.GetKeyDown (KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            if (index > 0)
            {
                index--;
                Vector2 position = transform.position;
                position.y += yOffset;
                transform.position = position;
            }
        }

        if (Input.GetKeyDown (KeyCode.Return) || Input.GetKeyDown(KeyCode.Space))
        {
            if (index == 0)
            {
                GoToGamePlay();
            }else if (index == 2)
            {
                QuitGame();
            }
        }
    }
        
    public void GoToGamePlay(){
        SceneManager.LoadScene("SampleScene");
    }
    public void QuitGame(){
        Application.Quit();
        Debug.Log("Game is Exit");
    }
}
