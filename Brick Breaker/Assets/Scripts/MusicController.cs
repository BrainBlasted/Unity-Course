using UnityEngine;
using System.Collections;

public class MusicController : MonoBehaviour {

	public static int MusicControllerCount = 0;

	void Awake ()	{
		MusicControllerCount++;
		print (MusicControllerCount);
		if (MusicControllerCount > 1)	{GameObject.Destroy(gameObject); print ("Duplicate ID " + GetInstanceID() + " Intercepted");}
	}
	// Use this for initialization
	void Start () {
		Debug.Log("MusicController " + GetInstanceID() + " Started");
		// Persist gameObject if there is not one in scene; Destroys object if there is one active.
		if (MusicControllerCount <=1)		{GameObject.DontDestroyOnLoad(gameObject);}
		else if (MusicControllerCount > 1)	{GameObject.Destroy(gameObject); print ("Duplicate ID " + GetInstanceID() + " Destroyed");}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
