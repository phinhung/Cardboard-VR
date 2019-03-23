using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rotation : MonoBehaviour {


	public GameObject Bahn; //Planetenbahn
	public float speed; //Rotationsgeschwindigkeit


	void RotationPlaneten(){
		if (objectgrabbed == false){
		transform.RotateAround (Bahn.transform.position, Vector3.up, speed * Time.deltaTime); //Rotieren des Planeten
		}
	}

	void RotationSonne(){
		if (objectgrabbed == false){
		transform.RotateAround (Bahn.transform.position, Vector3.up, speed * Time.deltaTime); //Rotieren der Sonne
		}
	}

	public bool isSnappedso;   // Anlegen der Variablen für die Planeten
	public bool isSnappedmerkur;
	public bool isSnappedv;
	public bool isSnappede;
	public bool isSnappedma;
	public bool isSnappedj;
	public bool isSnappeds;
	public bool isSnappedu;
	public bool isSnappedn;
	public bool finishsun;
	public bool finishn;
	public bool finishsa;
	public bool finishmer;
	public bool finishmar;
	public bool finisher;
	public bool finishve;
	public bool finishur;
	public bool finishju;
	public bool objectgrabbed;


    // Funktionen werden aufgerufen wenn Planet richtig gesnappt ist, setzt Planeten-Variable auf true 
    public void sonnesnapped()
    {
        isSnappedso = true;
    }
    public void merkursnapped()
    {
        isSnappedmerkur = true;
    }
    public void venussnapped()
    {
        isSnappedv = true;
    }
    public void erdesnapped()
    {
        isSnappede = true;
    }
    public void marssnapped()
    {
        isSnappedma = true;
    }
    public void jupitersnapped()
    {
        isSnappedj = true;
    }
    public void saturnsnapped()
    {
        isSnappeds = true;
    }
    public void uranussnapped()
    {
        isSnappedu = true;
    }
    public void neptunsnapped()
    {
        isSnappedn = true;
    }



    void Update () {

		//prüfen, ob Planeten an richtiger Stelle
		//rotieren, wenn Planet an richtiger Stelle
        //Variablen finish.. auf true setzen
		if (isSnappedmerkur == true) {
            finishmer = true;
			RotationPlaneten (); 
		}
		if (isSnappedv == true) {
			finishve = true;
			RotationPlaneten ();
		}
		if (isSnappede == true) {
			finisher = true;
			RotationPlaneten ();
		}
		if (isSnappedma == true) {
			finishmar = true;
			RotationPlaneten (); 
		}
		if (isSnappedj == true) {
			finishju = true;
			RotationPlaneten (); 
		}
		if (isSnappeds == true) {
			finishsa = true;
			RotationPlaneten (); 
		}
		if (isSnappedu == true) {
			finishur = true;
			RotationPlaneten (); 
		}
		if (isSnappedn == true) {
			RotationPlaneten (); 
			finishn = true;
		}
        if (isSnappedso == true) {
			RotationSonne ();
			finishsun = true;
		}

       }
	}

