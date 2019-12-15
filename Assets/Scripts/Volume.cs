using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class Volume : MonoBehaviour
{
    private AudioSource audioSrc;

    public GameObject AudioPanelUI;
    public GameObject SettingPanelUI;

    private float musicVolume = 1f;

    // Start is called before the first frame update
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        audioSrc.volume = musicVolume; 
    }

    public void SetVolume(float vol)
    {
        musicVolume = vol;
    }

    public void ActivateMenu()
    {
        AudioPanelUI.SetActive(true);
        Time.timeScale = 0;
       
    }

    public void DeactivateMenu()
    {
        AudioPanelUI.SetActive(false);        
    }

    public void ToSettingMenu()
    {
        SettingPanelUI.SetActive(true);
    }
}
