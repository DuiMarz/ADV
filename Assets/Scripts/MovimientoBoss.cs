using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.TimeZoneInfo;

public class MovimientoBoss : MonoBehaviour
{

    public float speed = 0.2f;
    public float speedGiros = 0.2f;
    public float gravity = 20.0f;
    public float transitionTime = 0.2f;
    private Vector3 moveDirection = Vector3.zero;
    private Vector2 currentInput;
    Animator animator;
    CharacterController controller;
    
    void Start()
    {
        animator = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float H = Input.GetAxis("Horizontal");
        float V = Input.GetAxis("Vertical");

        Vector2 targetInput = new(H, V);
        currentInput = Vector2.Lerp(currentInput, targetInput, Time.deltaTime / transitionTime);

        if (!controller.isGrounded)
        {
            moveDirection.y -= gravity * Time.deltaTime;
            controller.Move(moveDirection * Time.deltaTime);
            
        } else if (Input.GetKeyUp(KeyCode.Space))
        {
            animator.SetTrigger("Jump");
        }

        animator.SetFloat("Horizontal", currentInput.x * speedGiros);
        animator.SetFloat("Vertical", currentInput.y * speed);


    }
}
