using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public GameObject destructionFX;
    public GameObject hitEffect;

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
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void life(){

    }
    
     private void OnTriggerEnter2D(Collider2D other){
        if(other.transform.tag == "Enemy"){ 
            Instantiate(destructionFX, transform.position, Quaternion.identity);       
            GlobalScript.Instance.Life();
        } 
    }
    
}
