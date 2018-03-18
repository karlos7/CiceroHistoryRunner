using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOffset : MonoBehaviour {

	private Material materialAtual;
    public static float velociade = 0.15f;
    public static float velociadeChao = 3.2f;
	private float offset = 10f;

	// Use this for initialization
	void Start () {
		materialAtual = GetComponent<Renderer>().material;
    }

	// Update is called once per frame
	void Update () {
		if(materialAtual.name.Equals("Fundo (Instance)")){
			offset += velociade * Time.deltaTime;
		} else{
			
		}

        materialAtual.SetTextureOffset("_MainTex", new Vector2(offset, 0));
	}
}
