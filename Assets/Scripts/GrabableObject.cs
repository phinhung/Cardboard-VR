using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabableObject : MonoBehaviour {

	public GameObject player;
	public GameObject hand;
	public GameObject objecttograb;
	private float timeCount = 0.0f;
	public Transform from;
	Transform rotto;
	Transform to;

	void Update(){
		timeCount = timeCount + Time.deltaTime;
	}
	public void setobject(){
		if (hand.transform.childCount == 0) {
			player.GetComponent<PluginWrapper> ().objectA = objecttograb;
		}

	
	}

	public void opentelescope(){
		to.rotation = Quaternion.Euler(0,0,170);	
	transform.rotation = Quaternion.Slerp(from.rotation, to.rotation, 0.5f);
	}
}
