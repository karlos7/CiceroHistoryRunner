using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveObjeto : MonoBehaviour {

    public static float velocidade = -2f;
    private float x;
	private float aux;

	//Pontos
	public GameObject player;
	private bool pontuado;

	// Use this for initialization
	void Start () {
		//Pontos
		player = GameObject.Find("Player") as GameObject;
    }

	// Update is called once per frame
	void Update () {
		x = transform.position.x;
		x +=velocidade * Time.deltaTime;

		transform.position = new Vector3(x, transform.position.y, transform.position.z);
		if (x <= -49) {
			Destroy (transform.gameObject);
		}

		//Pontos

	}
}
