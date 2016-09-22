using UnityEngine;
using System.Collections;

public class SpawnerScript : MonoBehaviour {

    //public Transform background;
    public BoxCollider2D	 rt;
   

    public GameObject[] prefabs;
    public float delay = 1.0f;

	// Use this for initialization
	void Start () {

        //RectTransform rt = background.GetComponent<RectTransform>();
        StartCoroutine(blockGenerator());
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}



    public IEnumerator blockGenerator()
    {
        //this will return the method everytime the delay is not reached,
        //so the rest of the method is not called.
        yield return new WaitForSeconds(delay);


        //gets a random position between the min and max x values of the background
		Vector2 newPosition = new Vector2(Random.Range(-(rt.size.x/2), (rt.size.x/2)),transform.position.y);
        transform.position = newPosition;

        var newTransform = transform;

        Instantiate(prefabs[Random.Range(0, prefabs.Length)],newTransform.position,Quaternion.identity);

        StartCoroutine(blockGenerator());
    }
}
