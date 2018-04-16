﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptMenuPrincipal : MonoBehaviour {

	// Use this for initialization
	void Start () {
        PlayerPrefs.SetInt("music", 1);
        PlayerPrefs.SetInt("audio", 1);
        SonsMusicas.Instance.musicOn();
    }
	public void iniciarTutorial(){
        PlayerPrefs.SetInt("continueFase", 1);
        SceneManager.LoadScene("SelecionarPersonagem");
    }
    public void continueFase()
    {
        if (PlayerPrefs.GetInt("continueFase") == 1)
        {
            SceneManager.LoadScene("FaseUm");
        }
        else if (PlayerPrefs.GetInt("continueFase") == 2)
        {
            SceneManager.LoadScene("HistoriaDois");
        }
    }
    public void sair(){
		Application.Quit();
	}
	// Update is called once per frame
	void Update () {
		
	}
}
