﻿using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	private float rotatorSpeed = 3f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.forward * rotatorSpeed);

	}
}
