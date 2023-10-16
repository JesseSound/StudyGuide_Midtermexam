using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//use these to track score and push to UI
using UnityEngine.UI;
using TMPro;
public class PlayerMove : MonoBehaviour
{

    //name variables accurately. we need movespeed
    public float moveSpeed;
    //store the rigidbody in rb so we can access it later
    Rigidbody2D rb;




    // player lives and scores

    public int lives = 5;
    public int score = 0;

    //store the text in an object

    public TextMeshProUGUI scoreText;


    // Start is called before the first frame update
    void Start()
    {
        //find the component on the player on start, not update
        rb = GetComponent<Rigidbody2D>();

        scoreText.text = "Score: " + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        //check every frame for the score and change UI
        scoreText.text = "Score: " + score.ToString();



        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(moveSpeed, 0.0f);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-moveSpeed, 0.0f);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector2(0.0f, moveSpeed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector2(0.0f, -moveSpeed);
        }
        else
        {
            rb.velocity = Vector2.zero;
        }



    }
}
