using UnityEngine;
using System.Collections;

public class otherDemo : MonoBehaviour {
	public GameObject player;
	private Demo playerScript;


	// Use this for initialization
	void Start () {
		playerScript = player.GetComponent<Demo> ();
		playerScript.DamagePlayer (1000);
	}

	void Update () {
		if (playerScript.health <= 0) {
			//Debug.Log ("another object has detected that the palyer has died");
		}
	}
}
