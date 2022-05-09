using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Player : MonoBehaviour
{
    public CharacterController controller;

    public Vector3 movement;
    public Vector3 to;
    public float duration;
    public RotateMode mode;
    public float speed = 2.0f;
    public int points = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    void FixedUpdate()
    {
       controller.Move(movement * Time.fixedDeltaTime * speed);
    }

    // Update is called once per frame
    void Update()
    {

        movement.x = Input.GetAxis("Horizontal");
        movement.z = Input.GetAxis("Vertical");

        if (controller.isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                movement.y = 3f;
            }
        }
        else
        {
            movement.y -= 0.02f;
        }

        

    }
    //i am on the verge of tears rn if it won't work jesus christ save us all
 



}
