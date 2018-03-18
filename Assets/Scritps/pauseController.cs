﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseController : MonoBehaviour {
    //Pause
    public GameObject panelPause;
    public GameObject panelCuriosidades;
    public GameObject buttonPause;
    public GameObject tempo;
    private float segundos;
    // Use this for initialization
    void Start () {
        Time.timeScale = 1;
    }
	
	// Update is called once per frame
	void Update () {
        if (playerController.contCoin >= 5)
        {
            playerController.contCoin = 0;
            PlayerPrefs.SetInt("moedas", playerController.contCoin);
            panelCuriosidades.SetActive(true);
            Time.timeScale = 0;
        }
	}
    public void despause()
    {
        Time.timeScale = 1;
        if (Input.GetMouseButtonDown(1))
        {
            Time.timeScale = 0;
        }
    }
    private void Pause()
    {
        Time.timeScale = 0;
        if (Input.GetMouseButtonDown(0))
        {
            Time.timeScale = 1;
        }
    }

    public void despausar ()
    {
        Time.timeScale = 1;
        if (Input.GetMouseButtonDown(1))
        {
            Time.timeScale = 0;
        }
    }

    public void showPause()
    {
        panelPause.SetActive(true);
        buttonPause.SetActive(false);
        Pause();
    }

    public void resumeGame()
    {
        panelPause.SetActive(false);
        buttonPause.SetActive(true);
        despausar();
    }

    public void sair()
    {
        Application.Quit();
    }

    public void menuPrincipal()
    {
        SceneManager.LoadScene("telaPrincipal");
    }
    public void fecharCuriosidade()
    {
        panelCuriosidades.SetActive(false);
        tempo.SetActive(true);
        resumeGame();
    }
}
