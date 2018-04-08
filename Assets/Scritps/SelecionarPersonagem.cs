﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelecionarPersonagem : MonoBehaviour {
    int sexo = 1;
    int cor = 1;
    int personagem;
    public GameObject sel1;
    public GameObject sel2;
    public GameObject sel3;
    public GameObject sel4;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (sexo == 1){
            if (cor == 1){
                //Masculino cor clara;
                personagem = 1;
            }else{
                //Masculino cor escura;
                personagem = 2;
            }
        }else{
            if (cor == 1){
                //Feminino cor clara;
                personagem = 3;
            }else{
                //Feminino cor escura;
                personagem = 2;
            }
        }
	}

    public void masculino()
    {
        sexo = 1;
        sel1.SetActive(true);
        sel3.SetActive(false);
    }
    public void feminino()
    {
        sexo = 2;
        sel1.SetActive(false);
        sel3.SetActive(true);
    }
    public void cor1()
    {
        cor = 1;
        sel2.SetActive(true);
        sel4.SetActive(false);
    }
    public void cor2()
    {
        cor = 2;
        sel2.SetActive(false);
        sel4.SetActive(true);
    }
    public void continuar()
    {
        PlayerPrefs.SetInt("personagem", personagem);
        SceneManager.LoadScene("HistoriaUm");
    }
}
