using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {
	public GameObject moeda;
	// Use this for initialization
	void Start () {
		moeda = GameObject.Find("moeda") as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D collider){
		Destroy (transform.gameObject);
	}
}
