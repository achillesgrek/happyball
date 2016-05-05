//using UnityEngine;
//using System.Collections;
//using System;

//public class Player : MonoBehaviour
//{
//    [SerializeField]
//    private float moveSpeed;
//    [SerializeField]
//    private float sprintSpeed;

    

//    private double slowDown = 0.5;

//    public Transform groundCheck;
//    public float groundCheckRadius;
//    public LayerMask whatIsGround;
//    private bool grounded;

//    private Rigidbody2D myRigidbody;

//    [SerializeField][Range(1f,100f)]
//    private float thrust;



//    // Use this for initialization
//    void Start()
//    {
//        myRigidbody = GetComponent<Rigidbody2D>();
//    }

//    void FixedUpdate()
//    {
//        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
//    }

//    // Update is called once per frame
//    void Update()
//    {

//        Movement();
//        SlowDown();

//        Sprint();

//        Stop();



//    }
//    public void Movement()
//    {
//        if (Input.GetKey(KeyCode.D) && grounded)
//        {
//            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
//        }
//        if (Input.GetKey(KeyCode.D) && !grounded)
//        {
//            GetComponent<Rigidbody2D>().velocity = new Vector2(((float)(moveSpeed * slowDown)), GetComponent<Rigidbody2D>().velocity.y);
//        }
//        if (Input.GetKey(KeyCode.A) && grounded)
//        {
//            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
//        }
//        if (Input.GetKey(KeyCode.A) && !grounded)
//        {
//            GetComponent<Rigidbody2D>().velocity = new Vector2(((float)(-moveSpeed * slowDown)), GetComponent<Rigidbody2D>().velocity.y);
//        }
//    }
//    public void Sprint()
//    {
//        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.D))
//        {
//            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed * sprintSpeed, GetComponent<Rigidbody2D>().velocity.y);
//        }
//        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.A))
//        {
//            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed * sprintSpeed, GetComponent<Rigidbody2D>().velocity.y);
//        }
//    }
//    public void Stop()
//    {
//        if (Input.GetKey(KeyCode.Space))
//        {
//            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed * 0, GetComponent<Rigidbody2D>().velocity.y);
//        }
//    }
//    private void SlowDown()
//    {
//        //if(Input.GetKeyUp(KeyCode.D))
//        //{
//        //    GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed * 0, GetComponent<Rigidbody2D>().velocity.y);
//        //}
//    }
//}
