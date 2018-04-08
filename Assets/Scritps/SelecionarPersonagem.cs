using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelecionarPersonagem : MonoBehaviour {
    int sexo = 1;
    int cor = 1;
    int personagem;
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
    }
    public void feminino()
    {
        sexo = 2;
    }
    public void cor1()
    {
        cor = 1;
    }
    public void cor2()
    {
        cor = 2;
    }
    public void continuar()
    {
        PlayerPrefs.SetInt("personagem", personagem);
        SceneManager.LoadScene("HistoriaUm");
    }
}
