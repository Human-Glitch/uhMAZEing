//This script controls the translation of the sprite give to

//Borrowed from Blayne Mayfield

using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	public float speed = 0.1f;

	private float x, y;

	// Use this for initialization
	void Start () {

		Time.timeScale = 1;
	
	}
	
	// Update is called once per frame
	void Update () {
		x = Input.GetAxis ("Horizontal");
		//y = Input.GetAxis ("Vertical");

		transform.position = transform.position +
			new Vector3 (x * speed, 0, 0);
		
	}

}
