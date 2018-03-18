using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOffset : MonoBehaviour {

	private Material materialAtual;
    public static float velociade = 0.03f;
    public static float velociadeChao = 2.5f;
	private float offset = 5f;
	private float currentTime = 0;

	// Use this for initialization
	void Start () {
		materialAtual = GetComponent<Renderer>().material;
		currentTime = 0;
	}

	// Update is called once per frame
	void Update () {
		currentTime += Time.deltaTime;
		if(materialAtual.name.Equals("Fundo (Instance)")){
			offset += velociade * Time.deltaTime;
			if (currentTime >= 5) {
				currentTime = 0;
				velociade += 0.015f;
                spawnController.rateSpawn -= 0.4f;
                spawnController.rateSpawn2 -= 0.4f;
            }
		} else{
			offset += velociadeChao * Time.deltaTime;
			if (currentTime >= 5) {
				currentTime = 0;
				velociadeChao += 0.008f;
			}
		}
		materialAtual.SetTextureOffset("_MainTex", new Vector2(offset, 0));
	}
}
