using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody ball;
    public Rigidbody Tray; 

    // Start is called before the first frame update
    void Start()
    {
        ball = gameObject.GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Calculate the movement direction based on the input
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        ball.AddForce(movement * speed);
    }
    
    void OnCollisionEnter(Collision collision)
    {
        // Handle collision response
        if (collision.gameObject.CompareTag("Tray"))
        {
            /*
            if (Input.GetAxis("Horizontal") > 0) //right
            {
                ball.AddForce(Vector3.right * speed);
            }
            else if (Input.GetAxis("Horizontal") < 0) //left 
            {
                ball.AddForce(-Vector3.right * speed);
            }
            
            if (Input.GetAxis("Vertical") > 0) //forward 
            {
                ball.AddForce(Vector3.forward * speed);
            }
            else if (Input.GetAxis("Vertical") < 0) //backward
            {
                ball.AddForce(-Vector3.forward * speed);
            }
            */

                // Stop the ball from falling further
                //ball.velocity = Vector3.zero;
                //ball.isKinematic = true;
                // Move the ball to rest on top of the tray
                //transform.position = new Vector3(transform.position.x, tray.position.y, transform.position.z);

        }
            
    }



}
