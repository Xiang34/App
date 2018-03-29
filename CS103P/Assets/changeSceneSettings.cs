using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeSceneSettings : MonoBehaviour {
	public int changeTo;
	// Use this for initialization
	public void ChangeScene(int changeTo)
	{
		gameControl.saveChests ();
		SceneManager.LoadScene (changeTo);
	}
}
