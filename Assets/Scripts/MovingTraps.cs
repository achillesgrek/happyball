using UnityEngine;
using System.Collections;

public class MovingTraps : MonoBehaviour
{
    public GameObject mine;

    public float moveSpeed;

    public Transform currentPoint;

    public Transform[] points;

    public int pointSelection;


	// Use this for initialization
	void Start ()
    {
        currentPoint = points[pointSelection];
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        mine.transform.position = Vector3.MoveTowards(mine.transform.position, currentPoint.position, Time.deltaTime * moveSpeed);

        if(mine.transform.position == currentPoint.position)
        {
            pointSelection++;

            if(pointSelection == points.Length)
            {
                pointSelection = 0;
            }

            currentPoint = points[pointSelection];
        }
        
	}
}
