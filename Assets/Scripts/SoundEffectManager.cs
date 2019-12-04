using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundEffectManager : MonoBehaviour
{
    public static SoundEffectManager Instance;
    public AudioSource audioSource;

    public AudioClip sxfShoot;

    public AudioClip sxfExplotion;
    public AudioClip sfxButton;
    public bool isOn;
    public Text sfxButtonText;
  
    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public  void ToggleSFX(){
        isOn = !isOn; //set nilai isOn menjadi negatifnya
        sfxButtonText.text = isOn ? "SFX ON" : "SFX OFF";
    }

    public void Shoot(){
        audioSource.PlayOneShot(sxfShoot,1f);
    }

    public void Explotion(){
        audioSource.PlayOneShot(sxfExplotion,1f);
    }

}
