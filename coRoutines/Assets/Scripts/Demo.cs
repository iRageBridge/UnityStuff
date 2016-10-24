using UnityEngine;
using System.Collections;

public class Demo: MonoBehaviour{
	public int health;

	public enum WeaponType {
		Sword,
		Staff,
		Dagger,
		Mace
	}

	public WeaponType weaponType;

	public string[] arrayString;

	void Start(){

		arrayString = new string[2];
		arrayString [0] = "Hello";
		arrayString [1] = "World";

		for (int i = 0; i < arrayString.Length; i++) {
			//print (arrayString [i]);
		}
	}


	void Update(){

		switch (weaponType) {
			case WeaponType.Dagger:
				//print ("Dagger");
				break;
			case WeaponType.Sword:
				//print ("Sword");
				break;
			case WeaponType.Staff:
				//print ("Staff");
				break;
			case WeaponType.Mace:
				//print ("Mace");
				break;
		}

		DamagePlayer (1);
		if (health <= 0) {
			//health = 0;
			//Destroy (gameObject, 2.5f);
		}
		//Debug.Log(arrayString[0]);
	}

	public void DamagePlayer(int damage){
			health -= damage;
	}
}