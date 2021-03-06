﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchableObject : MonoBehaviour {

	private Material mat;
	public Color defaultColor;
	public Color selectedColor;

	void Start()
	{
		mat = GetComponent<Renderer>().material;
	}

	void onTouchDown()
	{
		mat.color = selectedColor;
	}

	void onTouchUp()
	{
		mat.color = defaultColor;
	}

	void onTouchStay()
	{
		mat.color = selectedColor;
	}

	void onTouchExit()
	{
		mat.color = defaultColor;
	}
} 