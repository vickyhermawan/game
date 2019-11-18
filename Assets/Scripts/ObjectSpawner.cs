using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
      // public GameObject[] objectToSpawn;
    public GameObject objectToSpawn;
    // Start is called before the first frame update

    public float spawnTime=5f;

    public float spawnPosy;

     public float spawnPosx;

    public float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = spawnTime;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime; 
        if(timer <= 0){
                GameObject obj = Instantiate(objectToSpawn, this.transform);
                obj.transform.position = new Vector3(spawnPosx,spawnPosy,0);
                timer = spawnTime;
            } 
    }
}
