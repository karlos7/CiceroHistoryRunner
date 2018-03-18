using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptMenuPrincipal : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	public void iniciarTutorial(){
		SceneManager.LoadScene("HistoriaUm");
	}
	public void sair(){
		Application.Quit();
	}
	// Update is called once per frame
	void Update () {
		
	}
}
