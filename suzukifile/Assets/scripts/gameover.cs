using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter(Collider other){
		if (player.flag == 0){
			if (other.gameObject.name == "Player") {
				SceneManager.LoadScene ("Gameover");
			}
		}
	}
}
