using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggered : MonoBehaviour
{
    public float playerSpeed;
    public void Start()
    {
        playerSpeed = gameObject.GetComponent<PlayerMove>().moveSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("SpeedUp")){
            gameObject.GetComponent<PlayerMove>().moveSpeed *= 2;
        }
        else if (collision.CompareTag("SlowDown")){
            gameObject.GetComponent<PlayerMove>().moveSpeed /= 2;
        }

        //deal with player score and health
        else if (collision.CompareTag("Obstacle"))
        {
            gameObject.GetComponent<PlayerMove>().lives-=1;
            //Destroy(collision.gameObject);
        }
        else if (collision.CompareTag("Collectible"))
        {
            gameObject.GetComponent<PlayerMove>().score += 1;
            
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //how do we leave the traps with our original speed??

        gameObject.GetComponent<PlayerMove>().moveSpeed = playerSpeed;

    }

}
