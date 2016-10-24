using UnityEngine;
using System.Collections;

public class Week4Practical : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//Task1 ();
		//Task2 ();
		Task3 ();
	}

	private int add(int i, int j){
		int sum = i + j;
		return sum;
	}

	public void Task1(){
		int answer = add (10, 5);
		Debug.Log (answer);
	}



	private bool isEven(int a){
		if (a % 2 == 0) {
			Debug.Log (a + " is even");
			return true;
		} 
		else {
			Debug.Log (a + " is odd");
			return false;
		}
	}

	public void Task2(){
		for (int i = 0; i < 10; i++) {
			isEven (i);
		}
	}

	public void Task3 (){
		while (true) {
			Debug.Log (Time.frameCount);
		}
	}
}
