using UnityEngine;
using System.Collections;

public class PicController : MonoBehaviour {
    public GameObject obj;
    public Vector3 start = new Vector3(0f,0.5f,5f);
	private Vector3 scale;
    // Use this for initialization
    void Start () {
		scale = transform.localScale;
        
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 look = new Vector3(obj.transform.position.x, 1, obj.transform.position.z);
       // transform.LookAt(obj.transform);
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position = Vector3.MoveTowards(transform.position, obj.transform.position, Time.deltaTime * 1);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = Vector3.MoveTowards(transform.position, obj.transform.position, Time.deltaTime * 1);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position = Vector3.MoveTowards(transform.position, start, Time.deltaTime * 1);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = Vector3.MoveTowards(transform.position, start, Time.deltaTime * 1);
        }
		if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			scale.x+=0.5f;
			scale.y+=0.5f;
			transform.localScale = scale;
		}
		if (Input.GetKeyDown(KeyCode.LeftArrow))
		{
			scale.x-=0.5f;
			scale.y-=0.5f;
			transform.localScale = scale;
		}
    }
}
