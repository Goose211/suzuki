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

	public float nextTime;
	public float interval = 1.0f;　　//点滅周期
	public Renderer b;


	// Use this for initialization
	void Start () {
		nextTime = Time.time;  //点滅機能


	
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
		text.text = "通ります！！ :" +boost.ToString();

		/*if (Input.GetKey (KeyCode.Space)) {
			A.layer= Action;

		}
		else if (Input.GetKey(KeyCode.UpArrow)){
			Action = A.layer;
		}*/
		if (Input.GetKeyDown(KeyCode.Space)) {
			if (sorry > 0) {
				if (Time.time > nextTime) {
					nextTime += interval;
				
				}
			
				flag = 1;
				Debug.Log ("flagChange");
				Invoke ("change", 3.5f);
				sorry--;
			}
		}
		text2.text = "すいません :" +sorry.ToString();

	}

	void change (){
		flag = 0;
	}


}



