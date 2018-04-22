using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vitoria : MonoBehaviour {
    // Use this for initialization
    void Start () {
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
        if (PlayerPrefs.GetInt("continueFase") == 1)
        {
            PlayerPrefs.SetInt("continueFase", 2);
            SceneManager.LoadScene("FaseDois");
        }
        else if (PlayerPrefs.GetInt("continueFase") == 2)
        {
            PlayerPrefs.SetInt("continueFase", 3);
            SceneManager.LoadScene("FaseTres");
        }
        else if (PlayerPrefs.GetInt("continueFase") == 3)
        {
            PlayerPrefs.SetInt("continueFase", 1);
            SceneManager.LoadScene("MenuPrincipal");
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
