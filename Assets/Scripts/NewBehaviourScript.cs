using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
	public float kecepatanGerak = 5f;
	public float kecepatanRotasi = 5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.RightArrow))
			transform.Translate (kecepatanGerak * Time.deltaTime, 0, 0);
		if (Input.GetKey(KeyCode.LeftArrow))
			transform.Translate (Vector3.left * kecepatanGerak * Time.deltaTime);
		if (Input.GetKey(KeyCode.UpArrow))
			transform.Translate (Vector3.up * kecepatanRotasi * Time.deltaTime);
		if (Input.GetKey(KeyCode.DownArrow))
			transform.Translate (-Vector3.up * kecepatanRotasi * Time.deltaTime);
	}
}
