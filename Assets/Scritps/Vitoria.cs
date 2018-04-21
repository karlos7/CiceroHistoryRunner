using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vitoria : MonoBehaviour {
    private int fase;
    // Use this for initialization
    void Start () {
        fases();
	}
    public void fases()
    {
        fase = PlayerPrefs.GetInt("continueFase");
        fase++;
    }

    public void sair()
    {
        Application.Quit();
    }

    public void menuPrincipal()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("telaPrincipal");
    }

    public void voltarJogo()
    {
        if (fase == 1)
        {
            PlayerPrefs.SetInt("continueFase", 1);
            SceneManager.LoadScene("FaseUm");
        }
        else if (fase == 2)
        {
            PlayerPrefs.SetInt("continueFase", 2);
            SceneManager.LoadScene("FaseDois");
        }
        else
        {
            SceneManager.LoadScene("SelecionarPersonagem");
        }
        playerController.contCoin = 0;
    }
    // Update is called once per frame
    void Update () {
		
	}
}
