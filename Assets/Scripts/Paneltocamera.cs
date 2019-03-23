using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paneltocamera : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	GameObject oAp;
	public GameObject objectA;
	public GameObject camera;
	// Update is called once per frame
	void Update () {
		oAp = objectA.transform.Find ("PanelMenu").gameObject;
		oAp.transform.LookAt (camera.transform);
	}
}
