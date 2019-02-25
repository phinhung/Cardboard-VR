using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PluginWrapper : MonoBehaviour {

    private AndroidJavaObject javaClass;
    public Text myText;
	public Text myText2;



	// Use this for initialization
	void Start () {
		Debug.Log ("Start");
        javaClass = new AndroidJavaObject("com.example.vrlibrary.Keys");
        javaClass.Call("LogNativeAndroidLogcatMessage");
        javaClass.Call("LogNumberSentFromUnity", 76);

		Debug.Log ("Juhu" + javaClass);

        myText.text = javaClass.Call<int>("AddFiveToMyNumber", 4).ToString();

		Physics.IgnoreLayerCollision(8, 2);
	}

	public GameObject szsonne;
	public GameObject szmerkur;
	public GameObject szvenus;
	public GameObject szerde;
	public GameObject szmars;
	public GameObject szjupiter;
	public GameObject szsaturn;
	public GameObject szuranus;
	public GameObject szneptun;
	// Update is called once per frame
	void Update () {
		myText.text = objectA.name;
		if (objectA.name == "Sonne") {
			szsonne.SetActive(true);
		} else {
			szsonne.SetActive(false);
		}

		if (objectA.name == "Merkur") {
			szmerkur.SetActive(true);
		} else {
			szmerkur.SetActive(false);
		}

		if (objectA.name == "Venus") {
			szvenus.SetActive(true);
		} else {
			szvenus.SetActive(false);
		}

		if (objectA.name == "Erde") {
			szerde.SetActive(true);
		} else {
			szerde.SetActive(false);
		}

		if (objectA.name == "Mars") {
			szmars.SetActive(true);
		} else {
			szmars.SetActive(false);
		}

		if (objectA.name == "Jupiter") {
			szjupiter.SetActive(true);
		} else {
			szjupiter.SetActive(false);
		}

		if (objectA.name == "Saturn") {
			szsaturn.SetActive(true);
		} else {
			szsaturn.SetActive(false);
		}

		if (objectA.name == "Uranus") {
			szuranus.SetActive(true);
		} else {
			szuranus.SetActive(false);
		}

		if (objectA.name == "Neptun") {
			szneptun.SetActive(true);
		} else {
			szneptun.SetActive(false);
		}
    }


	public void leiser(){
		myText.text = "leiser";
	}

	public void lauter(){
		myText.text = "lauter";
	}


	public GameObject hand;
	public GameObject objectA;
	public Transform objectB;
	public bool angeschaut=false;

	public bool snapallowed;
	Vector3 npos;

	public void greifen(string ok){
		//myText.text = "greifen"+ok;

		if ((ok == "1") && (angeschaut == true)) {
			if (hand.transform.childCount == 0) {
				Debug.Log ("yay");	
				objectA.transform.position = objectB.position;
				objectA.transform.parent = objectB;
				objectA.GetComponent<Rigidbody>().useGravity = false;
			}

			}
		else if ((ok == "1")&&(hand.transform.childCount == 1)){
			getpospointer ();

			npos.x = wpos.x;
			npos.z = wpos.z;
			npos.y = wpos.y+0.1f;
			objectA.transform.position = npos;
			hand.transform.DetachChildren ();


			if (snapallowed = true) {
				snap ();
			} else {
				objectA.GetComponent<Rigidbody> ().useGravity = true;
			}
		}
	}

	public GameObject snapzo;
	public GameObject objecttosnap;
	public GameObject planetenbahn;
	public GameObject snappos;
	bool enter=true;

	public void snap(){
		

		objectA.GetComponent<Rigidbody> ().useGravity = true;
		OnTriggerStay (snapzo.GetComponent<SphereCollider> ());

		if (objecttosnap.name == "Sonne") {
			objecttosnap.GetComponent<Rotation> ().isSnappedso = true;
		}

		if (objecttosnap.name == "Merkur") {
			objecttosnap.GetComponent<Rotation> ().isSnappedmerkur = true;
		}

		if (objecttosnap.name == "Venus") {
			objecttosnap.GetComponent<Rotation> ().isSnappedv = true;
		}

		if (objecttosnap.name == "Erde") {
			objecttosnap.GetComponent<Rotation> ().isSnappede = true;
		}

		if (objecttosnap.name == "Mars") {
			objecttosnap.GetComponent<Rotation> ().isSnappedma = true;
		}

		if (objecttosnap.name == "Jupiter") {
			objecttosnap.GetComponent<Rotation> ().isSnappedj = true;
		}

		if (objecttosnap.name == "Saturn") {
			objecttosnap.GetComponent<Rotation> ().isSnappeds = true;
		}

		if (objecttosnap.name == "Uranus") {
			objecttosnap.GetComponent<Rotation> ().isSnappedu = true;
		}

		if (objecttosnap.name == "Neptun") {
			objecttosnap.GetComponent<Rotation> ().isSnappedn = true;
		}
		
	}

 void OnTriggerStay(Collider other)
	{
		if (enter) {	
			//planetenbahn.GetComponent<SphereCollider> ().enabled = false;
			snappos.GetComponent<SphereCollider> ().enabled = false;
			objecttosnap.transform.position = snappos.transform.position;
			objectA.GetComponent<Rigidbody> ().useGravity = false;

		} else {
			objectA.GetComponent<Rigidbody> ().useGravity = true;
		}
	}

	public void anschauen(){
		angeschaut = true;
	}

	public void wegschauen(){
		angeschaut = false;
	}

	public GameObject pointer;
	public Vector3 wpos;

	public void getpospointer(){
		wpos = pointer.GetComponent<GvrReticlePointer> ().CurrentRaycastResult.worldPosition;
	
	}



}
