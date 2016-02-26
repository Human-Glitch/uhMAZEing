using UnityEngine;
using System.Collections;

[RequireComponent(typeof(PlayerMovement))]//Every Player Controller requires player movement
public class PlayerController : MonoBehaviour {
	[SerializeField]
	private float speed = 5.0f;
	private PlayerMovement movement;

	//[SerializedField]


	// Use this for initialization
	void Start () {
		Time.timeScale = 1f;
		movement = GetComponent<PlayerMovement> ();
	}
	
	// Update is called once per frame
	void Update () {
		float xMov = Input.GetAxis ("Horizontal");
		float zMov = Input.GetAxis ("Vertical");

		Vector3 moveHorizontal = transform.right * xMov;
		Vector3 moveVertical = transform.forward * zMov;

		//normalized means to scale everything down to one
		//required for mixed horizontal and vertical directions
		Vector3 velocity = (moveHorizontal + moveVertical).normalized * speed;

		movement.Move (velocity);

		//float yRot = Input.GetAxis ("Mouse X");

		//Vector3 rotation = new Vector3 (0, yRot, 0);

		//movement.Rotate (rotation);
	
	}
}
