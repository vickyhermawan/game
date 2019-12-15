using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    public Vector3 bulletPost;
    public GameObject objectToSpawn;
    public float timer;
    public float spawnTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {   
            
            GameObject obj = Instantiate(objectToSpawn, this.transform);
            obj.transform.localPosition = new Vector3(bulletPost.x,bulletPost.y,0);
            timer = spawnTime;
            SoundEffectManager.Instance.Shoot();
            
        }
    }

     
}
