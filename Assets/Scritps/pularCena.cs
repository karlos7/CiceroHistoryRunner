using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pularCena : MonoBehaviour {
	private float currentTime = 0f;
	// Use this for initialization
	void Start () {
		currentTime = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		currentTime += Time.deltaTime;
		if (currentTime >= 3.5f) {
			currentTime = 0f;
			SceneManager.LoadScene("telaPrincipal");
		}
	}
}
