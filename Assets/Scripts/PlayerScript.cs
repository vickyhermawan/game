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

    public bool alive;

     private void Awake()
    {
        if (instance == null) 
            instance = this;
            
    }
    
    // Start is called before the first frame update
    void Start()
    {
        alive = true;
        pesawat.SetActive(true);
        respawnTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(respawnTime > 0){
            respawnTime -= Time.deltaTime;
            print("timer");
        }else{
            respawnTime = 0;
            pesawat.SetActive(true);
        }
    }

    public void life(){

    }
    
     private void OnTriggerEnter2D(Collider2D other){
        if(other.transform.tag == "Enemy"){ 
            // alive = false;
            Instantiate(destructionFX, transform.position, Quaternion.identity);       
            GlobalScript.Instance.Life();
            pesawat.SetActive(false);

            respawnTime = 2;    
            transform.position = respawnPoint;
        
           

        } 
    }
    
}
