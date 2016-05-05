using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour
{
    public GameObject currentCheckpoint;

    private Player player;

    public GameObject deathParticle;

    public float respawnDelay;

    private float gravityStore;


    // Use this for initialization
    void Start ()
    {
        player = FindObjectOfType<Player>();
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    public void RespawnPlayer()
    {
        StartCoroutine("RespawnPlayerCo");
    }

    //public IEnumerator RespawnPlayerCo()
    //{
    //    Instantiate(deathParticle, player.transform.position, player.transform.rotation);
    //    player.enabled = false;
    //    player.GetComponent<Renderer>().enabled = false;
    //    gravityStore = player.GetComponent<Rigidbody2D>().gravityScale;
    //    player.GetComponent<Rigidbody2D>().gravityScale = 0f;
    //    player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
    //    Debug.Log("Player Respawn");
    //    yield return new WaitForSeconds(respawnDelay);
    //    player.transform.position = currentCheckpoint.transform.position;
    //    player.enabled = true;
    //    player.GetComponent<Renderer>().enabled = true;
    //    player.GetComponent<Rigidbody2D>().gravityScale = gravityStore;
    //}

    public IEnumerator RespawnPlayerCo()
    {
        Instantiate(deathParticle, player.transform.position, player.transform.rotation);
        player.enabled = false;
        player.GetComponent<Renderer>().enabled = false;
        //gravityStore = player.GetComponent<Rigidbody2D>().gravityScale;
        player.GetComponent<Rigidbody2D>().gravityScale = 0f;
        player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        Debug.Log("Player Respawn");
        yield return new WaitForSeconds(respawnDelay);
        player.transform.position = currentCheckpoint.transform.position;
        player.enabled = true;
        player.GetComponent<Renderer>().enabled = true;
        player.GetComponent<Rigidbody2D>().gravityScale = 1f;
    }
}
