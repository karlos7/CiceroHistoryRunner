using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuGameOver : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void sair(){
		Application.Quit();
	}

	public void menuPrincipal(){
		Time.timeScale = 1;
		SceneManager.LoadScene("telaPrincipal");
	}

	public void voltarJogo(){
        if (PlayerPrefs.GetInt("continueFase") == 1)
        {
            SceneManager.LoadScene("FaseUm");
        }
        else if (PlayerPrefs.GetInt("continueFase") == 2)
        {
            SceneManager.LoadScene("FaseDois");
        }
        else
        {
            SceneManager.LoadScene("SelecionarPersonagem");
        }
        playerController.contCoin=0;
    }

}
