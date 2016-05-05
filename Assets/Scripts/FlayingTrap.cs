using UnityEngine;
using System.Collections;

public class FlayingTrap : MonoBehaviour
{
    public float moveSpeed;
    public bool moveRight;

    public Transform wallCheck;
    public float wallCheckRadius;
    public LayerMask whatIsWall;
    private bool hittingWall;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        hittingWall = Physics2D.OverlapCircle(wallCheck.position, wallCheckRadius, whatIsWall);
        //hittingWall = Physics2D.OverlapCircleAll
        if (hittingWall)
        {
            moveRight = !moveRight;
        }
        if (moveRight)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }

    }

    //public Transform[] wallCheck;
    //public float wallCheckRadius;
    //public LayerMask whatIsWall;
    //private bool hittingWall;


    //// Use this for initialization
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{



    //}

    //private bool IsHitting()

    //{
    //    foreach (Transform point in wallCheck)
    //    {
    //        Collider2D[] colliders = Physics2D.OverlapCircleAll(point.position, wallCheckRadius, whatIsWall);

    //        if (hittingWall)
    //        {
    //            moveRight = !moveRight;
    //        }
    //        if (moveRight)
    //        {
    //            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
    //        }
    //        else
    //        {
    //            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
    //        }
    //    }

    //    return 0;
}

