using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class snap_allowed : MonoBehaviour {


	public Vector3 posleft;
	Vector3 posright;
	Vector3 center;
	public bool objectisgrabbed;
	public float Distanceri;
	public float Distancele;
	public float alloweddistance;
	public GameObject planet;
	public bool allowsnap;
	public GameObject left;
	public GameObject right;


	public void distance(){

		allowsnap = true;
	}

	void Update () {
		//Controller finden und deren Position einer Variable zuweisen
		 left = GameObject.Find ("left");
		posleft = left.GetComponent<PositionLeftHand> ().positionleft;

		right = GameObject.Find ("right");
		posleft = right.GetComponent<PositionRightHand> ().positionright;


		//prüfen, ob ein Planet gegriffen ist
		if (left.transform.childCount == 1){
			objectisgrabbed = true;
		}
		else if(left.transform.childCount == 0){
			objectisgrabbed = false;
		}
			
		if (Input.GetKeyDown (KeyCode.F1)) {
			objectisgrabbed = true;
		}


		//ausrechnen der Distanz
		if (objectisgrabbed == true) {
			Distanceri = Vector3.Distance (posright, center);
			Distancele = Vector3.Distance (posleft, center);
		//SnapDropZone aktiv/deaktiv setzen

				if (objectisgrabbed == true && (Distancele < alloweddistance | Distanceri < alloweddistance)) {
					GetComponent<VRTK_SnapDropZone>().enabled = false;
					GetComponent<SphereCollider>().enabled = false;
				}
				if (objectisgrabbed == true && (Distancele > alloweddistance | Distanceri > alloweddistance)) {
					GetComponent<VRTK_SnapDropZone>().enabled = true;
					GetComponent<SphereCollider>().enabled = true;

				}
			
		}

	}
}
