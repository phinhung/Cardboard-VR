using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Aufgabe3 : MonoBehaviour {

	public bool isSnappedSp1;
	public bool isSnappedSp2;
	public bool isSnappedLi;
    public bool finishSp1;
    public bool finishSp2;
    public bool finishLi;
    public Material mMaterial;

    public void Sp1snapped()
    {
        isSnappedSp1 = true;
    }
    public void Sp2snapped()
    {
        isSnappedSp2 = true;

    }
    public void Lisnapped()
    {
        isSnappedLi = true;
    }

     void Start()
    {
        mMaterial = GetComponent<Renderer>().material;
    }

    void Update () {
		if (isSnappedSp1 == true)
        { finishSp1 = true; }
        if (isSnappedSp2 == true)
        { finishSp2 = true; }
        if (isSnappedLi == true)
        { finishLi = true;  }
    }
}
