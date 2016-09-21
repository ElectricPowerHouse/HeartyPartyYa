using UnityEngine;
using System.Collections;

public class SpawnerScript : MonoBehaviour {

    //public Transform background;
    public RectTransform rt;
   

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

        float panelWidth = rt.rect.width * rt.localScale.x;
        float panelHeight = rt.rect.height * rt.localScale.y;
        float panelX = rt.rect.x * rt.localScale.x;
        float panelY = rt.rect.y * rt.localScale.y;

        //gets a random position between the min and max x values of the background
         Vector2 newPosition = new Vector2(Random.Range(0, rt.rect.width),transform.position.y);
        transform.position = newPosition;

        var newTransform = transform;

        Instantiate(prefabs[Random.Range(0, prefabs.Length)],newTransform.position,Quaternion.identity);

        StartCoroutine(blockGenerator());
    }
}
