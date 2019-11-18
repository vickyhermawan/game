using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public Vector3 playerPost;
    public float speedX;
    public float speedY;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        playerPost = transform.position;
      //KONTROL HORIZONTAL
        if (Input.GetAxis("Horizontal") > 0){ //jika pencet kanan atau posiif
            transform.Translate(speedX,0,0);
        }else if(Input.GetAxis("Horizontal") < 0)//jika pencet kiri atau negatif
        {
            transform.Translate(-speedX,0,0);
        }

        //KONTROL VERTICAL
         if (Input.GetAxis("Vertical") > 0){ //jika pencet kanan atau posiif
            transform.Translate(0,speedY,0);
        }else if(Input.GetAxis("Vertical") < 0)//jika pencet kiri atau negatif
        {
            transform.Translate(0,-speedY,0);
        }  
    }
}
