using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowTreasure : MonoBehaviour {

	private int treasure1, treasure2, treasure3, treasure4, treasure5, treasure6;

	public GameObject TreasureOne, TreasureTwo, TreasureThree, TreasureFour, TreasureFive, TreasureSix;

	// Use this for initialization
	void Start () {
		foreach (int chestNumber in gameControl.chestNumbersList) {
			switch (chestNumber) {
			case (1):
				Debug.Log ("Chest 1");
				TreasureOne.SetActive (true);
				break;
			case(2): 
				Debug.Log ("Chest 2");
				TreasureTwo.SetActive (true);
				break;
			case(3):
				Debug.Log ("Chest 3");
				TreasureThree.SetActive (true);
				break;
			case(4):
				Debug.Log ("Chest 4");
				TreasureFour.SetActive (true);
				break;
			case(5):
				Debug.Log ("Chest 5");
				TreasureFive.SetActive (true);
				break;
			case(6):
				Debug.Log ("Chest 6");
				TreasureSix.SetActive (true);
				break;

			}
		}

				
	}
	
	// Update is called once per frame
	void Update () {
		
			
	}
}
