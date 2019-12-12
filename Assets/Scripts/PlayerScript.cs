using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public GameObject destructionFX;
    public GameObject hitEffect;

    public GameObject pesawat;

    public float respawnTime;
    public Vector3 respawnPoint;    

    public static PlayerScript instance;

     private void Awake()
    {
        if (instance == null) 
            instance = this;
            
    }
    
    // Start is called before the first frame update
    void Start()
    {
        //alive = true;
        respawnPlayer();

    }

    // Update is called once per frame
    void Update()
    {
    }

    public void respawnPlayer(){
        pesawat.SetActive(true);
        transform.position = respawnPoint;
    }
    
     private void OnTriggerEnter2D(Collider2D other){
        if(other.transform.tag == "Enemy"){ 
            // alive = false;
            Instantiate(destructionFX, transform.position, Quaternion.identity);       
            GlobalScript.Instance.Life();
            pesawat.SetActive(false);
            SoundEffectManager.Instance.Explotion();
            Invoke("respawnPlayer",respawnTime);  // Pakai Invoke untuk memanggil satu method,dengan delay waktu yang ditentukan
        } 
    }
    
}
