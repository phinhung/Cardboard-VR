using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PluginWrapper : MonoBehaviour {

    private AndroidJavaObject javaClass;
    public Text myText;
	public bool angeschaut=false;
	public Transform objectA;
	public Transform objectB;

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

	public void greifen(string ok){
		myText.text = "greifen"+ok;

		if ((ok == "1") && (angeschaut==true)) {
			Debug.Log ("yay");	
			objectA.position = objectB.position;
			objectA.parent = objectB;
		}
	}

	public void anschauen(){
		angeschaut = true;
	}

	public void wegschauen(){
		angeschaut = false;
	}

}
