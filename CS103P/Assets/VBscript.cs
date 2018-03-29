using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VBscript : MonoBehaviour, IVirtualButtonEventHandler {
	int time = 1;
	public GameObject vButton1;
	public GameObject Character;
	Animator otherAnimator;

	// Use this for initialization
	void Start () {
		vButton1.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		otherAnimator = Character.GetComponent<Animator> ();


	}

	public void OnButtonPressed (VirtualButtonBehaviour vb) 
	{
		Debug.Log ("Button DOWN!");
		otherAnimator.SetFloat ("Kick", 0.5f);

	}

	public void OnButtonReleased(VirtualButtonBehaviour vb) 
	{
		Debug.Log ("Button RELEASED!!!!");
		otherAnimator.SetFloat ("Kick", 0.0f);
	}
	
	// Update is called once per frame

}
