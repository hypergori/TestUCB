using UnityEngine;
using System.Collections;

public class Contoller : MonoBehaviour {

	public Rigidbody rb ; 
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxis ("Vertical");
	
		rb.AddForce (new Vector3 (h, 0, v) * 10);
	}
}
