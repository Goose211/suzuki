using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameoverController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke ("ReturnTostart", 5.0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void ReturnTostart (){
		SceneManager.LoadScene ("start");
	}
}
