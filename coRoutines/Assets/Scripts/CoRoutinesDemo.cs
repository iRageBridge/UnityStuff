﻿using UnityEngine;
using System.Collections;

public class CoRoutinesDemo : MonoBehaviour {
	 

	// Use this for initialization
	void Start () {
		StartCoroutine (Go(5f, "Simon", "Standbridge"));
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator Go (float wait, string text1, string text2){
		print (Time.time + " " + text1);
		yield return new WaitForSeconds (wait);
		print (Time.time + " " + text2);
	}
}
