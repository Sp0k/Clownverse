using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController controller;
    public Transform groundCheck;
    public Animator anim;

    public float gravity = -9.81f;
    public int speed = 5;
    public int jumpForce = 10;
    public float turnSmoothTime = 0.1f;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    public float maxJumpSpeed = 100;

    Vector3 velocity;
    float turnSmoothVelocity;
    bool isGrounded;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0) 
        {
            velocity.y = -2f;
        }

        if (Input.GetKeyDown("space"))
        {
            if (velocity.y < maxJumpSpeed)
               velocity.y += jumpForce;
        }

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0, angle, 0);

            controller.Move(direction * speed * Time.deltaTime);
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        anim.SetBool("Walking", isGrounded && direction.magnitude >= 0.1f);
    }
}
