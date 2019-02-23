using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PluginWrapper : MonoBehaviour {

    private AndroidJavaObject javaClass;
    public Text myText;



	// Use this for initialization
	void Start () {
		Debug.Log ("Start");
        javaClass = new AndroidJavaObject("com.example.vrlibrary.Keys");
        javaClass.Call("LogNativeAndroidLogcatMessage");
        javaClass.Call("LogNumberSentFromUnity", 76);

		Debug.Log ("Juhu" + javaClass);

        myText.text = javaClass.Call<int>("AddFiveToMyNumber", 4).ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
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

	public void greifen(string ok){
		myText.text = "greifen"+ok;

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
			if (snapallowed = false) {
				objectA.transform.position = wpos;
				objectA.GetComponent<Rigidbody> ().useGravity = true;
				hand.transform.DetachChildren ();
			}

			if (snapallowed = true) {
				hand.transform.DetachChildren ();
				snap ();
			}
		}
	}

	public GameObject snapzo;
	public GameObject objecttosnap;
	public GameObject planetenbahn;
	public GameObject snappos;

	public void snap(){
		

			planetenbahn.GetComponent<SphereCollider> ().enabled = false;
			snappos.GetComponent<SphereCollider> ().enabled = false;
			objecttosnap.transform.position = snappos.transform.position;
		
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
