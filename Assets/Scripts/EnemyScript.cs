using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public GameObject destructionVFX;

    public GameObject EnemyShoot;

    [HideInInspector] public int shotChance; //probability of 'Enemy's' shooting during tha path
    [HideInInspector] public float shotTimeMin, shotTimeMax; //max and min time for shooting from the beginning of the path
    // Start is called before the first frame update
    void Start()
    {
        Invoke("ActivateShooting", 2);
    }

    void ActivateShooting() 
    {
        if (Random.value < (float)shotChance / 100)                             //if random value less than shot probability, making a shot
        {                         
            Instantiate(EnemyShoot, gameObject.transform.position, Quaternion.identity);             
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }

     private void OnTriggerEnter2D(Collider2D other){
        if(other.transform.tag == "Shoot"){ 
            Instantiate(destructionVFX, transform.position, Quaternion.identity);       
            Destroy(this.gameObject);
            GlobalScript.Instance.AddScoreA();
        }
    }


}
