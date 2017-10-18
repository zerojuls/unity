﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectsScript : MonoBehaviour {

	//Makes a private variable that the "inspector" in unity can see
	[SerializeField] private float objectSpeed = 1;
	private float resetPosition = 98.4f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		//ACCESS ASSIGNED OBJECT'S TRANSFORM COMPONENT
		//MOVE LEFT 20 * [time since last frame]
		transform.Translate(Vector3.right * (objectSpeed * Time.deltaTime));

		if (transform.localPosition.x >= resetPosition) {

			Vector3 newPos = new Vector3(-80.5f, transform.position.y, transform.position.z);
			transform.position = newPos;

		}

	}
}
