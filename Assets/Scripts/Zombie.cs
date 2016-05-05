using UnityEngine;
using System.Collections;

public class Zombie : MonoBehaviour
{
    public int pointsToAdd;

    public GameObject zombieDeath;

    // Use this for initialization
    void Start ()
    {
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            Instantiate(zombieDeath, gameObject.transform.position, gameObject.transform.rotation);
            ScoreManager.AddPoints(pointsToAdd);
            Destroy(gameObject);
        }
    }
}
