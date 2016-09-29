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


        if (Input.GetKey("d"))
        {

            x1 -= speed;
        }
        if (Input.GetKey("g"))
        {
            x1 += speed;
        }
        if (Input.GetKey("f"))
        {
            y1 -= speed;
        }
        if (Input.GetKey("r"))
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


	/*
	public Rigidbody2D obj1;
	public Rigidbody2D obj2;


	public int jump;
	public int speed;


	// Use this for initialization
	void Start () {

		obj1.GetComponent<Rigidbody>();
		obj2.GetComponent<Rigidbody>();

	}

	// Update is called once per frame
	void FixedUpdate () {



		float p1Move = 0f;
		float p2Move = 0f;


		if (Input.GetKey ("a") && p1Move > -1) {

			p1Move -= 0.1f;
		} 
		if (Input.GetKey ("d") && p1Move < 1) {

			p1Move += 0.1f;
		}
		if (Input.GetKey (KeyCode.LeftArrow) && p2Move > -1) {

			p2Move -= 0.1f;
		} 
		if (Input.GetKey (KeyCode.RightArrow) && p2Move < 1) {

			p2Move += 0.1f;
		}


		float p1Vertical = 0;
		float p2Vertical = 0;

		if (Input.GetKeyDown ("space")) {
			p1Vertical = jump;
		}
		if (Input.GetKeyDown (KeyCode.RightShift)) {
			p2Vertical = jump;
		}

		Vector2 p1 = new Vector2 (p1Move * speed, p1Vertical);
		Vector2 p2 = new Vector2 (p2Move * speed, p2Vertical);

		obj1.AddForce (p1,ForceMode.Impulse);
		obj2.AddForce (p2,ForceMode.Impulse);


	}
	*/
}
