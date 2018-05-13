using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class player : MonoBehaviour {
	public GameObject A;
	public float speed = 2.0f;
	public float slideSpeed =1.0f;

	public Text text;
	public int boost = 1;

	public Text text2;
	public int sorry = 3;

	public Text timeLabel;
	public LayerMask Action;
	public static int flag =0;



	// Use this for initialization
	void Start () {
		
	}


	// Update is called once per frame
	void Update () {
		transform.position += transform.forward * speed * Time.deltaTime;
		float pos_x = transform.position.x;
		if (Input.GetKey (KeyCode.LeftArrow)) {
			if (pos_x > -9.0f) {
				transform.position += 　Vector3.left * slideSpeed * Time.deltaTime;
			}
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			if (pos_x < 9.0f) {
				transform.position += 　Vector3.right * slideSpeed *Time.deltaTime;
			}
		}

		if (Input.GetKeyDown(KeyCode.DownArrow)){
			if(boost > 0){
				GetComponent<Rigidbody>().AddForce(0,0,478);
				boost --;
			}
		}	
		text.text = "Boost :" +boost.ToString();

		/*if (Input.GetKey (KeyCode.Space)) {
			A.layer= Action;

		}
		else if (Input.GetKey(KeyCode.UpArrow)){
			Action = A.layer;
		}*/
		if (Input.GetKey (KeyCode.Space)) {
			flag = 1;
			Debug.Log ("flagChange");
			Invoke ("change", 3.5f);
		}
		text2.text = "Sorry :" +sorry.ToString();

	}

	void change (){
		flag = 0;
	}


}



