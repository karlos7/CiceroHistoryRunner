using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class ScriptPause : MonoBehaviour {

	public GameObject panelPause;
	public GameObject buttonPause;
	private float currentTime;
	private float segundos;

	// Use this for initialization
	void Start () {
		panelPause.SetActive (false);
	}
	private void pause(){
		Time.timeScale = 0;
		if (Input.GetMouseButtonDown(0)) {
			Time.timeScale = 1;
		}
	}

	public void despause(){
        Time.timeScale = 1;
        if (Input.GetMouseButtonDown(1))
        {
            Time.timeScale = 0;
        }
    }

	public void showPause(){
		panelPause.SetActive (true);
		buttonPause.SetActive (false);
        pause ();
    }

	public void resumeGame(){
        panelPause.SetActive (false);
		buttonPause.SetActive (true);
        despause ();
	}

	public void sair(){
		Application.Quit();
	}

	public void menuPrincipal(){
		SceneManager.LoadScene("telaPrincipal");
	}

}
