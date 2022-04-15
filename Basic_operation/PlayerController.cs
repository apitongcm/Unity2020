using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //adjust speed 
    private float speed = 20.0f;
    private float turnSpeed = 40.5f;
    //inputs
    private float horizontalInput;
    private float forwardInput;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput  = Input.GetAxis("Vertical");
        // THIS IS A COMMENT!!
        // Move vehicle forward (Time.deltaTime to adjust vehicle's speed)
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput ); 

        //Rotate instead of Slide
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
