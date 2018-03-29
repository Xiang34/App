using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class gameControl : MonoBehaviour {

	public static int chestsCollected = 0;
	public static List<int> chestNumbersList = new List<int>();
	public TextMeshProUGUI chestsTexts;
	private GameObject uiCanvas;
	// Use this for initialization
	void awake() {
		DontDestroyOnLoad (gameObject);
				
	}
	void Start () {

		uiCanvas = GameObject.Find ("UICanvas").gameObject;
		uiCanvas.transform.Find ("Help Panel").gameObject.SetActive (false);

		loadChests ();
		saveChests ();

	}
	
	// Update is called once per frame
	void Update () {
		chestsTexts.text = "Chests Collected: " + chestsCollected;
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			resetGame ();
		}
	}

	public static void saveChests() {
		PlayerPrefs.SetInt ("chestsCollected", chestsCollected);
		foreach (int chestCollected in chestNumbersList) {
			Debug.Log ("Chests saved!");
			switch (chestCollected) {
			case 1:
				PlayerPrefs.SetInt ("chest1", 1);
				break;
			case 2:
				PlayerPrefs.SetInt ("chest2", 2);
				break;
			case 3:
				PlayerPrefs.SetInt ("chest3", 3);
				break;
			case 4:
				PlayerPrefs.SetInt ("chest4", 4);
				break;
			case 5:
				PlayerPrefs.SetInt ("chest5", 5);
				break;
			case 6:
				PlayerPrefs.SetInt ("chest6", 6);
				break;
			}
		}

	}
	public static void loadChests() {
		if (PlayerPrefs.HasKey ("chestsCollected")) {
			chestsCollected = PlayerPrefs.GetInt ("chestsCollected");
		} else {
			Debug.Log ("Nothing to load");
			if (PlayerPrefs.HasKey ("chest1"))
				chestNumbersList.Add (1);
			if (PlayerPrefs.HasKey ("chest2"))
				chestNumbersList.Add (2);
			if (PlayerPrefs.HasKey ("chest3"))
				chestNumbersList.Add (3);
			if (PlayerPrefs.HasKey ("chest4"))
				chestNumbersList.Add (4);
			if (PlayerPrefs.HasKey ("chest5"))
				chestNumbersList.Add (5);
			if (PlayerPrefs.HasKey ("chest6"))
				chestNumbersList.Add (6);
		}
	}
	public static void resetGame() {
		Debug.Log ("RESET TRIGGERED");
		PlayerPrefs.DeleteAll();
		chestNumbersList = new List<int>();
		chestsCollected = 0;
		saveChests ();
		loadChests ();

	}

			
}
