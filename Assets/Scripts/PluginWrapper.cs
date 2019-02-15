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
			objectA.transform.position = objectB.position;
			objectA.GetComponent<Rigidbody>().useGravity = true;
			hand.transform.DetachChildren ();
		}
	}

	public void anschauen(){
		angeschaut = true;
	}

	public void wegschauen(){
		angeschaut = false;
	}





}
