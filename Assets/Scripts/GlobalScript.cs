using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GlobalScript : MonoBehaviour
{
     public static GlobalScript Instance;
     public int score_a;
     public int nyawa_a = 3; 
     public Text textnyawa;
     public Text textscore_a;
     public Text final_score_text;
     public int min_life = 0;
     public GameObject panelGameover;
     public bool isGameOver;
    
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        textnyawa.text = "life : " + nyawa_a;
    }

    // Update is called once per frame
    void Update()
    {
         print("Score A = "+score_a);
    }

    public void AddScoreA(){
        score_a ++;
        textscore_a.text = "Score : " + score_a;
    }

    public void Life(){
        nyawa_a --;
        textnyawa.text = "life : " + nyawa_a;
    }
}
