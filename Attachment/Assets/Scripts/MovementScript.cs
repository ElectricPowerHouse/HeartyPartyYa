using UnityEngine;
using System.Collections;

public class MovementScript : MonoBehaviour {

    float x1;
    float y1;
    float x2;
    float y2;
    public float speed = 50f;
   

    public GameObject player1;
    public GameObject player2;

    public Rigidbody2D rigidBody1;
    public Rigidbody2D rigidBody2;
  



    // Use this for initialization
    void Start()
    {
        rigidBody1 = player1.GetComponent<Rigidbody2D>();
        rigidBody2 = player2.GetComponent<Rigidbody2D>();

    }

   

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey("a"))
        {

            x1 -= speed;
        }
        if (Input.GetKey("d"))
        {
            x1 += speed;
        }
        if (Input.GetKey("s"))
        {
            y1 -= speed;
        }
        if (Input.GetKey("w"))
        {
            y1 += speed;
        }



        if (Input.GetKey("right"))
        {

            x2 += speed;
        }
        if (Input.GetKey("left"))
        {

            x2 -= speed;
        }
        if (Input.GetKey("down"))
        {

            y2 -= speed;
        }
        if (Input.GetKey("up"))
        {

            y2 += speed;
        }



        Vector2 pos1 = new Vector2(x1, y1);
        Vector2 pos2 = new Vector2(x2, y2);
        rigidBody1.AddForce(pos1, ForceMode2D.Impulse);
        rigidBody2.AddForce(pos2, ForceMode2D.Impulse);

        x1 = 0;
        y1 = 0;
        x2 = 0;
        y2 = 0;
        
     
    }
}
