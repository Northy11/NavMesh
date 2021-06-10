using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController control;
    public float speed = 15.0f;
    Vector3 velocity;
    public float gravMod = -981f;
    public float height = 3.0f;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    public float upForce;
    
    public float JumpHeight = 3.0f;
    bool isGrounded;
    Rigidbody rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask); 

        if(isGrounded && velocity.y < 1)
        {
            velocity.y = -2f;
        }


        float hori = Input.GetAxis("Horizontal");
        float verti = Input.GetAxis("Vertical");

        Vector3 movement = transform.right * hori + transform.forward * verti; // If new Vector3 is used, it would take global coordinates and then our mouselook would make no sense.
        
        control.Move(movement * speed*Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            velocity.y = upForce;
            control.Move(velocity);
            Debug.Log("test");
        }
        

       



        velocity.y = -gravMod * Mathf.Pow(Time.deltaTime, 2);
        
        control.Move(velocity );
    }
    
}   
   
