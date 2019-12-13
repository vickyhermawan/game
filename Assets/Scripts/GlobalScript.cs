using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GlobalScript : MonoBehaviour
{
     public static GlobalScript Instance;
     public int score_a;
     public int highscore;
     public int nyawa_a;
     public Text textnyawa;
     public Text textscore_a;
     public Text final_score_text;
     public int min_life;
     public GameObject panelGameOver;
     public Text textGameOver;
     public Text textRestart;
     public Text textHighscore;
     public bool isGameOver;
    
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        //textnyawa.text = "life : " + nyawa_a;
        panelGameOver.SetActive(false);
        highscore = PlayerPrefs.GetInt("highscore",highscore);
        textHighscore.text = highscore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (score_a > highscore)
        {
            highscore = score_a;
            textHighscore.text = "highscore\n"+ highscore;
            PlayerPrefs.SetInt("highscore",highscore);
        }

         //print("Score A = "+score_a);
         Restart();
    }

    public void AddScoreA(){
        score_a ++;
        textscore_a.text = "Score : " + score_a;
    }

    public void Life(){
        nyawa_a --;
        textnyawa.text = "life : " + nyawa_a;
        if (nyawa_a == min_life)
        {
            GameOver();
        }
    }

    public void Restart(){
        if (Input.anyKeyDown && isGameOver)
        {
            Time.timeScale = 1;
            SceneManager.LoadSceneAsync("SampleScene");
        }
    }

    public void GameOver(){
        Time.timeScale = 0;
        isGameOver = true;
        textGameOver.text = "GAME OVER";
        panelGameOver.SetActive(true);
        Debug.Log("Game Over");
    }
}
