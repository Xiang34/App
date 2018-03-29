using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class OpenHelpPanel : MonoBehaviour {

	public GameObject helpCanvas;
	// Use this for initialization
	public void openHelpPanel()
	{
		if (helpCanvas.activeSelf == false) {
			helpCanvas.SetActive (true);
			//VuforiaRenderer.Instance.Pause (true);
		} else {
			helpCanvas.SetActive (false);
			//VuforiaRenderer.Instance.Pause (false);
		}
			
		

	}
}
