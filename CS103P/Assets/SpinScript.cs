using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinScript : MonoBehaviour {
	public bool spinning = false;
	private AnimationScript anim;
	// Use this for initialization
	void Start () {
		anim = gameObject.GetComponent<AnimationScript> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (spinning == true) {
			float runTime = 0.0001f;
			anim.isRotating = true;
			while (runTime < 3) {
				anim.rotationSpeed = (100 / runTime);
				runTime += Time.deltaTime;

			}
			anim.rotationSpeed = 10;
			spinning = false;
		}



	}
}
