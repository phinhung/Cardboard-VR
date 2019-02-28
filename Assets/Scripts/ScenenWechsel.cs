using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenenWechsel : MonoBehaviour {

    float time;

	void Update () {
        if (time > 4)
        {
            SceneManager.LoadScene("Intro",LoadSceneMode.Single);
        }
        time = Time.deltaTime + time;	
	}
}
