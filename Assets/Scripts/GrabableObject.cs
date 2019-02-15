using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabableObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public GameObject player;
	public GameObject hand;
	public GameObject objecttograb;
	public void setobject(){
		if (hand.transform.childCount == 0) {
			player.GetComponent<PluginWrapper> ().objectA = objecttograb.transform;
		}
	}
}
