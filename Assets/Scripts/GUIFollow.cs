using UnityEngine;
using System.Collections;

public class GUIFollow : MonoBehaviour {
	public Transform Target;

	// Update is called once per frame
	void LateUpdate () {
		transform.position = new Vector3 (Target.position.x, 2.5f, Target.position.z);

	}
}
