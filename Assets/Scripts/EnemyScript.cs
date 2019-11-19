using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public GameObject destructionVFX;
    // Start is called before the first frame update
    void Start()
    {
        
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
