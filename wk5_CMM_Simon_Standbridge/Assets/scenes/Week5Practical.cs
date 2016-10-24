using UnityEngine;
using System.Collections;

public class Week5Practical : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Task1 ();
	}

	private void printArrayOfNumbers(int[] numbers){
		for (int i = 0; i < numbers.Length; i++) {
			Debug.Log ("Element " + i + " is " + numbers [i]);
		}
	}

	public void Task1(){
		int[] test = { 3, 5, 2, 6, 7, 3 };
		printArrayOfNumbers (test);
	}

	public class someWords{
		public string someMoreWords = {"hello", "world"};
	}

	private void Task2(){
		foreach (string element in someWords) {
			Debug.Log (element);
		}
		Debug.Log ();
	}
}
