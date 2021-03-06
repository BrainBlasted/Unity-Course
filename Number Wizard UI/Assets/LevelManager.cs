﻿using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	// load level
	public void LoadLevel(string name){
		Debug.Log("Level load requested for: " + name);
		Application.LoadLevel(name);
	}

	public void QuitRequest(){
		Debug.Log("Quit request received.");
		Application.Quit();
	}
}
