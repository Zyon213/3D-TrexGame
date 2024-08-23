﻿using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5;
    [SerializeField] float jumpSpeed = 5f;
    [SerializeField] float jumpForce = 400f;
    [SerializeField] LayerMask groundMask;
    bool alive = true;
    private Rigidbody rg;
    private bool grounded;
    private Animator animator;
    private bool isDown;
    private CapsuleCollider cap;

    public float speedIncreasedPerPoint = 0.1f;
    //public Rigidbody rg;
    // Start is called before the first frame update
    void Start()
    {
        rg = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        cap = GetComponent<CapsuleCollider>();
    }
    private void FixedUpdate()
    {
        if (!alive)
            return;
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        rg.MovePosition(rg.position + forwardMove);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            Jump();
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) && grounded)
        {
            cap.radius = 0.7f;
            isDown = true;
        }
        if (Input.GetKeyUp(KeyCode.DownArrow) && grounded)
        {
            cap.radius = 0.9f;
            isDown = false;
        }
         animator.SetBool("IsDown", isDown);


        animator.SetBool("IsGround", grounded);

    }

  private  void Jump()
    {

        float height = GetComponent<Collider>().bounds.size.y;
        bool isGround = Physics.Raycast(transform.position, Vector3.down, (height / 2) * 0.1f, groundMask);

        rg.AddForce(Vector3.up * jumpForce);
       grounded = false;

    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
            grounded = true;
    }
}
