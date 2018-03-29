using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSceneManager : MonoBehaviour {
	private GameObject UICanvas;
	private GameObject HelpPanel;
	private GameObject ExitPanel;
	// Use this for initialization
	void Start () {
		UICanvas = GameObject.Find ("UICanvas");
		HelpPanel = UICanvas.transform.Find ("Help Panel").gameObject;
		ExitPanel = UICanvas.transform.Find ("Exit Panel").gameObject;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Debug.Log ("Esc Pressed on main screen");
			if (HelpPanel.activeSelf == true) {
				HelpPanel.SetActive (false);
			} else if (ExitPanel.activeSelf == true) {
				ExitPanel.SetActive (false);
			}
			else 
				ExitPanel.SetActive (true);

		}
	}
}
