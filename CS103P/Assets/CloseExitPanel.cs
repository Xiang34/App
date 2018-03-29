using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseExitPanel : MonoBehaviour {
	public GameObject ExitPanel;
	// Use this for initialization

	public void closePanel() {
		ExitPanel.SetActive (false);
	}
		
		
}
