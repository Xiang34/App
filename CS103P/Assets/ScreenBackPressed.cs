using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenBackPressed : MonoBehaviour {

	// Use this for initialization
	public void ChangeScene(int changeTo)
	{
		SceneManager.LoadScene (changeTo);
	}
}
