using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour {
	public Transform target;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 relatifPosisi = (target.position + new Vector3(0, 1.5f, 0)) - transform.position;
		Quaternion rotasi = Quaternion.LookRotation (relatifPosisi);
		Quaternion lokalObjek = transform.localRotation;
		transform.localRotation = Quaternion.Slerp (lokalObjek, rotasi, Time.deltaTime);//Slerp memperlembut putaran rotasi
		transform.Translate(0, 0, 3 * Time.deltaTime);
	}
}
