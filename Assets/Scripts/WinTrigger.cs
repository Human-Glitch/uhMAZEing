using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WinTrigger : MonoBehaviour {
	public GameObject winScreen;
	public GameObject gameOverScreen;
	public GameObject player;

	// Use this for initialization
	void Start () {
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player") {
			player.SetActive (false);
			gameOverScreen.SetActive (true);
			winScreen.SetActive (true);
			Time.timeScale = 0f;
		}
	}

}
