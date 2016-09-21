using UnityEngine;
using System.Collections;

public class BlockMoveScript : MonoBehaviour {


    public GameObject block;

    public Vector2 velocity = Vector2.zero;

    private Rigidbody2D rigidBody;

	// Use this for initialization
	void Start () {

        block.SetActive(true);
        rigidBody = GetComponent<Rigidbody2D>();


	
	}
	
	// Update is called once per frame
	void Update () {


        transform.Rotate(Vector3.forward * -0.2f);


        rigidBody.velocity = velocity;
	
	}
}
