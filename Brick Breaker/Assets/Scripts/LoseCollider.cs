using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {
	public LevelManager levelManager;
	// On collision w/ trigger
	void OnTriggerEnter2D(Collider2D collider)	{
		print ("trigger");
		//Application.LoadLevel("Lose");
		levelManager.LoadLevel("Lose");
	}

	void OnCollisionEnter2D(Collision2D collision)	{
		print ("Collision");
		//Application.LoadLevel("Lose");
	}
}
