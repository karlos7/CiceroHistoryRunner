using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveObjeto : MonoBehaviour {

    public static float velocidade = -2f;
    private float x;
	private float currentTime;
	private float aux;

	//Pontos
	public GameObject player;
	private bool pontuado;

	// Use this for initialization
	void Start () {
		//Pontos
		player = GameObject.Find("Player") as GameObject;
		currentTime = 0;
		aux = 10;
	}

	// Update is called once per frame
	void Update () {
		currentTime = Time.time;
		if (currentTime >= aux) {
			aux += 10;
			velocidade -= 0.015f;
        } else {
			
		}


		x = transform.position.x;
		x +=velocidade * Time.deltaTime;

		transform.position = new Vector3(x, transform.position.y, transform.position.z);
		if (x <= -49) {
			Destroy (transform.gameObject);
		}

		//Pontos

	}
}
