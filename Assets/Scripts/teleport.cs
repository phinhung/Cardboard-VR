using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public GameObject play;
	Vector3 newpos;
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.F7)){
			getpospointer ();
			newpos.x = wpos.x;
			newpos.z = wpos.z;
			newpos.y = 1.66f;
			play.transform.position = newpos;

			
		}
		
	}

	public GameObject pointer;
	public Vector3 wpos;

	public void getpospointer(){
		wpos = pointer.GetComponent<GvrReticlePointer> ().CurrentRaycastResult.worldPosition;
		Debug.Log (wpos);
	}
}
