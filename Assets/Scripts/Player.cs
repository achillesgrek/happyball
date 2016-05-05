using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour
{

    private Rigidbody2D myRigidbody;

    private Animator myAnimator;

    [SerializeField]
    private float movementSpeed;

    private bool facingRight;

    private bool attack;

    [SerializeField]
    [Range(0f, 1000f)]
    private float _testValue = 30f;


    // Use this for initialization
    void Start()
    {
        facingRight = true;
        myRigidbody = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        HandleInput();
    }

    void FixedUpdate()
    {
        float horizontal = 0f;


#if UNITY_ANDROID
         //tutaj z tego filmiku, no i wywal z HandleMovement ten input, w handleinput to samo co tutaj 
         horizontal = CrossPlatformInputManager.GetAxis("Horizontal");
         if(CrossPlatformInputManager.GetButtonDown("Jump")) attack = true;
          
           
#else
        horizontal = Input.GetAxis("Horizontal");
        HandleInput();
#endif

        HandleMovement(horizontal);
        Flip(horizontal);

        //HandleAttacks();

        attack = false;
    }

    private void HandleMovement(float horizontal)
    {
        Vector2 moveVec = new Vector2(horizontal, 0f);
        if (attack)
        {
            myAnimator.SetBool("attack", true);

            moveVec.x *= _testValue;

            //myRigidbody.velocity = new Vector2(horizontal * 30, myRigidbody.velocity.y);
            GetComponent<AudioSource>().Play();
        }
        else
        {
            myAnimator.SetBool("attack", false);
            moveVec.x *= movementSpeed;
            //myRigidbody.velocity = new Vector2(horizontal * movementSpeed, myRigidbody.velocity.y);
        }
        myRigidbody.AddForce(moveVec);
        myAnimator.SetFloat("speed", Mathf.Abs(myRigidbody.velocity.x));
    }

    //private void HandleAttacks()
    //{

    //}

    private void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift) && !attack)
        {
            attack = true;
        }
    }

    private void Flip(float horizontal)
    {
        if (horizontal > 0 && !facingRight || horizontal < 0 && facingRight)
        {
            facingRight = !facingRight;
            Vector3 theScala = transform.localScale;
            theScala.x *= -1;
            transform.localScale = theScala;
        }
    }

    //void EnableRagdoll()
    //{
    //    myRigidbody.isKinematic = false;
       
    //}
    
}