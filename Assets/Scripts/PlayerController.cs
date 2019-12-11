using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Borders
{
    public float minXOffset = 1f, maxXOffset = 1f, minYOffset = 1f, maxYOffset = 1f;

    public float minX, maxX, minY, maxY;
}

public class PlayerController : MonoBehaviour
{
    public Borders borders;
    Camera mainCamera;
    public Vector3 playerPost;
    public float speedX;
    public float speedY;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
        ResizeBorders();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, borders.minX,borders.maxX),
                                Mathf.Clamp(transform.position.y, borders.minY,borders.maxY), transform.position.z);
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

    void ResizeBorders() 
    {
        borders.minX = mainCamera.ViewportToWorldPoint(Vector2.zero).x + borders.minXOffset;
        borders.minY = mainCamera.ViewportToWorldPoint(Vector2.zero).y + borders.minYOffset;
        borders.maxX = mainCamera.ViewportToWorldPoint(Vector2.right).x - borders.maxXOffset;
        borders.maxY = mainCamera.ViewportToWorldPoint(Vector2.up).y - borders.maxYOffset;
    }
}
