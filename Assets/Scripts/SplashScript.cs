using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SplashScript : MonoBehaviour
{
    public float timer = 3;
    public SpriteRenderer splash;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SplashTime());
    }

    // Courotine - fungsi task thread yang bisa dipakai timer
    IEnumerator SplashTime()
    {
        yield return new WaitForSeconds(timer);

        int countStepTransparent = 20;
        float duration = 1f;
        for(int i = 0; i < countStepTransparent; i++)
        {
            splash.color = new Color (1,1,1,1f/i);
            yield return new WaitForSeconds(duration/countStepTransparent);
        }
    
    //SceneManager.LoadScene("Nama Scene");
    SceneManager.LoadScene("MenuScene");
    }
}
