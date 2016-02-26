using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour {

	private Vector3 velocity = Vector3.zero;
	private Rigidbody rigidBody;
	private AudioSource audioSource;

	// Use this for initialization
	void Start () {
		rigidBody = GetComponent<Rigidbody> ();
		audioSource = GetComponent<AudioSource> ();
	}

	public void Move(Vector3 _velocity) {
		this.velocity = _velocity;
		Debug.Log ("Move activated");
		if (velocity == Vector3.zero) {
			audioSource.Play ();
		}
	}

	public void Rotate(Vector3 _rotation) {
		//this.rotation = _rotation;
	}

	void FixedUpdate(){
		//Smooths out animation
		rigidBody.MovePosition (rigidBody.position + velocity * Time.fixedDeltaTime);

		//rigidBody.MoveRotation (rigidBody.rotation * Quaternion.Euler (_rotation));
	}
}