using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOffset : MonoBehaviour {

	private Material materialAtual;
    public float velociade;
    public static float velociadeChao = 3.2f;
	private float offset = 1f;

	// Use this for initialization
	void Start () {
		materialAtual = GetComponent<Renderer>().material;
    }

	// Update is called once per frame
	void Update () {
		if(materialAtual.name.Equals("Fundo (Instance)")){offset += velociade * Time.deltaTime;}
        else if (materialAtual.name.Equals("Fundo2 (Instance)")) { offset += velociade * Time.deltaTime; }
        else if (materialAtual.name.Equals("Fundo3 (Instance)")) { offset += velociade * Time.deltaTime; }
        else if (materialAtual.name.Equals("Fundo4 (Instance)")) { offset += velociade * Time.deltaTime; }
        else if (materialAtual.name.Equals("Fundo5 (Instance)")) { offset += velociade * Time.deltaTime; }

        materialAtual.SetTextureOffset("_MainTex", new Vector2(offset, 0));
	}
}
