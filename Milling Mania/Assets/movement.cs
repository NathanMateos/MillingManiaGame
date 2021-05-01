using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    float posX;
    float posY;
    float posZ;

    // Start is called before the first frame update
    void Start()
    {
        posX = transform.position.x;
        posY = transform.position.y;
        posZ = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
            posZ --;
        if(Input.GetKeyDown(KeyCode.S))
            posZ ++;
        if(Input.GetKeyDown(KeyCode.D))
            posX --;
        else if(Input.GetKeyDown(KeyCode.A))
            posX ++;
        move();
    }

    public void move(){
        transform.position = new Vector3(posX,posY,posZ);
    }
}
