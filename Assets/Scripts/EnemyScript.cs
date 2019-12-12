using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public int health;
    public GameObject destructionVFX;

    public GameObject EnemyShoot;

    public int shotChance; //probability of 'Enemy's' shooting during tha path
    public float shotTimeMin, shotTimeMax; //max and min time for shooting from the beginning of the path
    // Start is called before the first frame update
    void Start()
    {
        Invoke("ActivateShooting", Random.Range(shotTimeMin,shotTimeMax));
    }

    void ActivateShooting() 
    {
        if (Random.value < (float)shotChance / 1)                             //if random value less than shot probability, making a shot
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
            health--;
            Instantiate(destructionVFX, transform.position, Quaternion.identity); 
            if (health == 0)
            {
            Instantiate(destructionVFX, transform.position, Quaternion.identity);       
            Destroy(this.gameObject);
            SoundEffectManager.Instance.Explotion();
            GlobalScript.Instance.AddScoreA();
        }
    }


}
