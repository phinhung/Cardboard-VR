using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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

	public GameObject szdeneb;
	public GameObject szvega;
	public GameObject szcapella;
	public GameObject szatair;
	public GameObject szalumi;

	public GameObject szsp1;
	public GameObject szsp2;
	public GameObject szli;
	bool cansnap;
	// Update is called once per frame
	void Update () {
		cansnap = snapzo.GetComponent<snap_allowed> ().snapallow;
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


		//für Aufgabe 2 jeweils die SnapZone des jeweiligen Stern aktiv setzen, wenn dieser gegriffen
		if (objectA.name == "DenebBall") {
			szdeneb.SetActive(true);
		} else {
			szdeneb.SetActive(false);
		}

		if (objectA.name == "VegaBall") {
			szvega.SetActive(true);
		} else {
			szvega.SetActive(false);
		}

		if (objectA.name == "CapellaBall") {
			szcapella.SetActive(true);
		} else {
			szcapella.SetActive(false);
		}

		if (objectA.name == "AtairBall") {
			szatair.SetActive(true);
		} else {
			szatair.SetActive(false);
		}

		if (objectA.name == "AluMiBall") {
			szalumi.SetActive(true);
		} else {
			szalumi.SetActive(false);
		}

		//für Aufgabe 3 jeweils die SnapZone des jeweiligen Objektes aktiv setzen, wenn dieser gegriffen
		if (objectA.name == "Objektivspiegel") {
			szsp1.SetActive(true);
		} else {
			szsp1.SetActive(false);
		}

		if (objectA.name == "Sekundaerspiegel") {
			szsp2.SetActive(true);
		} else {
			szsp2.SetActive(false);
		}

		if (objectA.name == "Sekundaerspiegel") {
			szli.SetActive(true);
		} else {
			szli.SetActive(false);
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
				objectA.transform.position = objectB.position;
				objectA.transform.rotation = Quaternion.Euler(0,0,0);
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


			if ((snapallowed = true)&&(objecttosnap==objectA)&&(cansnap == true)) {
				szene = SceneManager.GetActiveScene();

				snap ();
			} else {
				if (GameObject.Find("DenebBall").name=="DenebBall") {
					objectA.GetComponent<Rigidbody> ().useGravity = false;
				} else {
					objectA.GetComponent<Rigidbody> ().useGravity = true;
				}
			}
		}
	}

	Scene szene;
	public GameObject snapzo;
	public GameObject objecttosnap;
	public GameObject planetenbahn;
	public GameObject snappos;
	bool enter=true;
	public GameObject teleskop;

	public void snap(){
		

		objectA.GetComponent<Rigidbody> ().useGravity = true;
		OnTriggerStay (snapzo.GetComponent<SphereCollider> ());

		if (objecttosnap.name == "Sonne") {
			objecttosnap.GetComponent<Rotation> ().isSnappedso = true;
			objectA.transform.rotation = Quaternion.Euler(0,0,0);

		}

		if (objecttosnap.name == "Merkur") {
			objecttosnap.transform.localScale -= new Vector3(0.5f, 0.5f, 0.5f);
			objectA.transform.rotation = Quaternion.Euler(0,0,0);
			objecttosnap.GetComponent<Rotation> ().isSnappedmerkur = true;
		}

		if (objecttosnap.name == "Venus") {
			objecttosnap.transform.localScale -= new Vector3(0.5f, 0.5f, 0.5f);
			objectA.transform.rotation = Quaternion.Euler(0,0,0);
			objecttosnap.GetComponent<Rotation> ().isSnappedv = true;
		}

		if (objecttosnap.name == "Erde") {
			objecttosnap.transform.localScale -= new Vector3(0.5f, 0.5f, 0.5f);
			objecttosnap.GetComponent<Rotation> ().isSnappede = true;
			objectA.transform.rotation = Quaternion.Euler(90,0,0);
		}

		if (objecttosnap.name == "Mars") {
			objectA.transform.rotation = Quaternion.Euler(90,0,0);
			objecttosnap.transform.localScale -= new Vector3(0.5f, 0.5f, 0.5f);
			objecttosnap.GetComponent<Rotation> ().isSnappedma = true;
		}

		if (objecttosnap.name == "Jupiter") {
			objecttosnap.transform.localScale += new Vector3(0.3f, 0.3f, 0.3f);
			objectA.transform.rotation = Quaternion.Euler(-30,0,-45);
			objecttosnap.GetComponent<Rotation> ().isSnappedj = true;
		}

		if (objecttosnap.name == "Saturn") {
			objecttosnap.transform.localScale += new Vector3(0.2f, 0.2f, 0.2f);
			objectA.transform.rotation = Quaternion.Euler(-180,0,0);
			objecttosnap.GetComponent<Rotation> ().isSnappeds = true;
		}

		if (objecttosnap.name == "Uranus") {
			objecttosnap.transform.localScale += new Vector3(0.5f, 0.5f, 0.5f);
			objectA.transform.rotation = Quaternion.Euler(0,0,0);
			objecttosnap.GetComponent<Rotation> ().isSnappedu = true;
		}

		if (objecttosnap.name == "Neptun") {
			objectA.transform.rotation = Quaternion.Euler(90,0,0);
			objecttosnap.GetComponent<Rotation> ().isSnappedn = true;
		}

		if (objecttosnap.name == "DenebBall") {
			objecttosnap.GetComponent<Aufgabe2> ().isSnappedDe = true;
			//objecttosnap.GetComponent<Aufgabe2>().Stern_Material.color = Color.green;
		}

		if (objecttosnap.name == "VegaBall") {
			objecttosnap.GetComponent<Aufgabe2> ().isSnappedVe = true;
			//objecttosnap.GetComponent<Aufgabe2>().Stern_Material.color = Color.green;
		}

		if (objecttosnap.name == "CapellaBall") {
			objecttosnap.GetComponent<Aufgabe2> ().isSnappedCa = true;
			//objecttosnap.GetComponent<Aufgabe2>().Stern_Material.color = Color.green;
		}

		if (objecttosnap.name == "AtairBall") {
			objecttosnap.GetComponent<Aufgabe2> ().isSnappedAt = true;
			//objecttosnap.GetComponent<Aufgabe2>().Stern_Material.color = Color.green;
		}

		if (objecttosnap.name == "AluMiBall") {
			objecttosnap.GetComponent<Aufgabe2> ().isSnappedAluMi = true;
			//objecttosnap.GetComponent<Aufgabe2>().Stern_Material.color = Color.green;
		}

		if (objecttosnap.name == "Objektivspiegel") {
			objectA.transform.rotation = Quaternion.Euler(-90,0,0);
			objecttosnap.GetComponent<Aufgabe3> ().isSnappedSp1 = true;
			//objecttosnap.GetComponent<Aufgabe3>().mMaterial.color = Color.green;
			objectA.GetComponent<SphereCollider> ().enabled = false;
			objectA.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
			objectA.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;

		}

		if (objecttosnap.name == "Sekundaerspiegel") {
			objectA.transform.rotation = Quaternion.Euler(-90,0,0);
			objecttosnap.GetComponent<Aufgabe3> ().isSnappedSp2 = true;
			//objecttosnap.GetComponent<Aufgabe3>().mMaterial.color = Color.green;
			objectA.GetComponent<SphereCollider> ().enabled = false;
			objectA.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
			objectA.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;

		}

		if (objecttosnap.name == "konvexe Linse") {
			objectA.transform.rotation = Quaternion.Euler(-90,0,0);
			objecttosnap.GetComponent<Aufgabe3> ().isSnappedLi = true;
			//objecttosnap.GetComponent<Aufgabe3>().mMaterial.color = Color.green;
			objectA.GetComponent<SphereCollider> ().enabled = false;
			objectA.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
			objectA.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;

		}
	}



	void OnTriggerStay(Collider other)
	{
		if( (enter)&& (snapallowed)) {
				
			//planetenbahn.GetComponent<SphereCollider> ().enabled = false;
			snappos.GetComponent<SphereCollider> ().enabled = false;
			objecttosnap.transform.position = snappos.transform.position;
			objectA.GetComponent<Rigidbody> ().useGravity = false;


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

	GameObject oA;
	bool panelactive=false;
	public GameObject camera;
	public void infopanel(string oki) {
		if ((oki == "1")&&(hand.transform.childCount == 1)&&(panelactive == false)){
			oA = objectA.transform.Find ("PanelMenu").gameObject;
			oA.SetActive (true);
			panelactive = true;
			oA.transform.LookAt (camera.transform);
		
			
		} else	if ((panelactive == true)&&(hand.transform.childCount == 1)&&(oki == "1")){
			oA.SetActive (false);
			panelactive = false;




	}


		


	}



}
