using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float sprintMod = 2.0f;
    public float gravity = 20.0f;
    public bool standingStill;

    CharacterController controller;
    float vSpeed;

    Vector3 moveDirection;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (standingStill == false)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0,
                                        Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;

            if (Input.GetButton("Sprint"))
            {
                moveDirection *= sprintMod;
            }

            if (controller.isGrounded)
            {
                vSpeed = 0;
                if (Input.GetButtonDown("Jump"))
                {
                    vSpeed = jumpSpeed;
                }
            }

            vSpeed -= gravity * Time.deltaTime;
            moveDirection.y = vSpeed;
            controller.Move(moveDirection * Time.deltaTime);
        }
    }
}