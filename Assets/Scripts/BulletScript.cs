using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    
    public static BulletScript bulletScriptInstance;
    
    public GameObject pooledBullet;
    private bool notEnoughBulletsinPool = true;

    private List<GameObject> bullets;

    private void Awake(){
        bulletScriptInstance = this;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        bullets = new List<GameObject>();
    }

    public GameObject GetBullet(){
        if (bullets.Count > 0 ){
            for(int i =0; i<bullets.Count; i++){
                if(!bullets[i].activeInHierarchy){
                    return bullets[i];
                }
            }
        }

        if(notEnoughBulletsinPool){
            GameObject bul = Instantiate(pooledBullet);
            bul.SetActive(false);
            bullets.Add(bul);
            return bul;
        }

        return null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
