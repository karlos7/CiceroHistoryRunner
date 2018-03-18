using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameOver : MonoBehaviour {

	public UnityEngine.UI.Text pontos;
	public UnityEngine.UI.Text recorde;
	public UnityEngine.UI.Text moedas;
	// Use this for initialization
	void Start () {
		pontos.text = PlayerPrefs.GetInt ("pontuacao").ToString ();
		recorde.text = PlayerPrefs.GetInt ("recorde").ToString ();//sdfgjh
		moedas.text = PlayerPrefs.GetInt ("moedas").ToString ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
