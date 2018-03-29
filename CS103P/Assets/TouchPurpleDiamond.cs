using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchPurpleDiamond : MonoBehaviour {

		// This stores the layers we want the raycast to hit (make sure this GameObject's layer is included!)
	public LayerMask LayerMask = UnityEngine.Physics.DefaultRaycastLayers;
	private Animator anim;
	private bool Collected = false;
	public int targetNumber;



	// This stores the finger that's currently dragging this GameObject
	private Lean.LeanFinger draggingFinger;

	void Awake(){

		DontDestroyOnLoad (transform.gameObject);
	}

	void Start() {
		anim = gameObject.GetComponent<Animator> ();
	}

	protected virtual void OnEnable()
	{
		// Hook into the OnFingerDown event
		Lean.LeanTouch.OnFingerDown += OnFingerDown;

		// Hook into the OnFingerUp event
		Lean.LeanTouch.OnFingerUp += OnFingerUp;
	}

	protected virtual void OnDisable()
	{
		// Unhook the OnFingerDown event
		Lean.LeanTouch.OnFingerDown -= OnFingerDown;

		// Unhook the OnFingerUp event
		Lean.LeanTouch.OnFingerUp -= OnFingerUp;
	}

	/*protected virtual void LateUpdate()
{
	// If there is an active finger, move this GameObject based on it
	if (draggingFinger != null)
	{
		Lean.LeanTouch.MoveObject(transform, draggingFinger.DeltaScreenPosition);
	}
}*/

	public void OnFingerDown(Lean.LeanFinger finger)
	{
		// Raycast information
		var ray = finger.GetRay();
		var hit = default(RaycastHit);

		// Was this finger pressed down on a collider?
		if (Physics.Raycast(ray, out hit, float.PositiveInfinity, LayerMask) == true)
		{
			// Was that collider this one?
			if (hit.collider.gameObject == gameObject)
			{
				// Set the current finger to this one
				draggingFinger = finger;
				//Show treasure Card
				if (Collected == false) {
					gameControl.chestsCollected++;
					Collected = true;
					gameControl.chestNumbersList.Add (targetNumber);
				}


			}
		}
	}

	public void OnFingerUp(Lean.LeanFinger finger)
	{
		// Was the current finger lifted from the screen?
		if (finger == draggingFinger)
		{
			// Unset the current finger

			draggingFinger = null;
		}
	}
}

