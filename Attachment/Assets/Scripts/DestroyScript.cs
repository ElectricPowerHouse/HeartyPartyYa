using UnityEngine;
using System.Collections;

public class DestroyScript : MonoBehaviour {

    public GameObject block;
    public Transform trans;

    public float offset = 999;

    public GameObject background;
    public RectTransform rt;

	// Use this for initialization
	void Start () {

        background = GameObject.Find("Background");
        rt = background.GetComponent<RectTransform>();
        trans = block.GetComponent<Transform>();
	
	}
	
	// Update is called once per frame
	void Update () {

        if(trans.position.y < -((rt.rect.y * rt.localScale.y) + (rt.rect.height * rt.localScale.y)))
        {
            Destroy(block);
        }
	
	}
}
