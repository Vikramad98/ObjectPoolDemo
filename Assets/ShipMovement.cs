using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{

    float horizontalInput;
    public float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(horizontalInput*speed*Time.deltaTime, 0, 0);
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bullet = ObjectPool.SharedInstance.GetPooledObject();
            if (bullet != null)
            {
                bullet.transform.position = this.transform.position;
                bullet.transform.position = this.transform.position;
                bullet.SetActive(true);
            }
        }
        if(transform.position.x>7.5f || transform.position.x<-7.5f)
        {
            transform.position = this.transform.position;
        }
    }
}
