using UnityEngine;
using System.Collections;

// This script allows you to drag this GameObject using any finger, as long it has a collider
public class SimpleDrag : MonoBehaviour
{
	// This stores the layers we want the raycast to hit (make sure this GameObject's layer is included!)
	public LayerMask LayerMask = UnityEngine.Physics.DefaultRaycastLayers;
	private AnimationScript anim;
	private bool Collected;
	public int targetNumber;
	public bool AnimState;


	
	// This stores the finger that's currently dragging this GameObject
	private Lean.LeanFinger draggingFinger;

	void Awake(){

		DontDestroyOnLoad (transform.gameObject);
	}

	void Start() {
		anim = gameObject.GetComponent<AnimationScript> ();
		Debug.Log ("Chest" + targetNumber);
		if (PlayerPrefs.HasKey ("chest" + targetNumber)) {
			
			Collected = true;
			AnimState = true;
		} else {
			Collected = false;
			AnimState = false;
		}
	}

	void Update() {
		if (PlayerPrefs.HasKey ("chest" + targetNumber)) {
			Collected = true;
		} else {
			Collected = false;
		}
		if (Collected == true) {
			if (AnimState != true) {
				CollectedAnimation ();
				AnimState = true;
			}
		} else {
			if (AnimState == true) {
				StaticAnimation ();
				AnimState = false;
			}
		}
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
				if (Collected == false) {
					//play fireworks animation
					//gameObject.GetComponent<SpinScript>().spinning = true;
					gameControl.chestsCollected++;
					Collected = true;
					gameControl.chestNumbersList.Add (targetNumber);
					gameControl.saveChests ();
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

	public void CollectedAnimation() {
		anim.isScaling = false;
		anim.isFloating = true;
		anim.isRotating = true;
	}

	public void StaticAnimation() {
		anim.isScaling = true;
		anim.isFloating = false;
		anim.isRotating = false;
	}

		
		
}