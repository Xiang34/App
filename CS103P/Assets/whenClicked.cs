using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;



public class whenClicked : MonoBehaviour {
	private Animator anim;

	// Use this for initialization
	void Start () {
		anim = gameObject.GetComponent<Animator> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnMouseDown()
	{
		if (anim.GetFloat ("Kick") == 0) {
			anim.SetFloat ("Kick", 0.5F);
		} 
		else {
			anim.SetFloat ("Kick", 0);
		}
	}
}
