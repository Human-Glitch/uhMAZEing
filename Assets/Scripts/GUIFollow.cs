using UnityEngine;
using System.Collections;

public class GUIFollow : MonoBehaviour {
	public Transform Target;
	public float followHeight = 2.5f;

	// Update is called once per frame
	void LateUpdate () {
		transform.position = new Vector3 (Target.position.x, followHeight, Target.position.z);

	}
}
