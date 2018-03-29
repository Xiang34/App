using UnityEngine;
using System.Collections;
using Vuforia;

public class whenTouched : MonoBehaviour
{
	public Color defaultColor;
	public Color selectedColor;
	public GameObject generated;

	private Material mat;
	private Animator anim;

	void Start()
	{
		mat = GetComponent<Renderer>().material;
		anim = gameObject.GetComponent<Animator> ();

	}

	void onTouchDown()
	{
		if (anim.GetFloat ("Kick") == 0) {
			anim.SetFloat ("Kick", 0.5F);
		}
		Debug.Log ("Object Touched");
		Instantiate (generated, this.transform.position, Quaternion.identity);
	}

	void onTouchUp()
	{
		anim.SetFloat ("Kick", 0);
		Debug.Log ("Object Released");
	}

	void onTouchStay()
	{
		return;
	}

	void onTouchExit()
	{
		return;
	}
}
