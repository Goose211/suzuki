﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sideenemy : MonoBehaviour {
	public float speed = 2.0f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += transform.right * speed * Time.deltaTime;

	}
}
