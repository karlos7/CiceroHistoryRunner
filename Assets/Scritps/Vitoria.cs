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
        if (PlayerPrefs.GetInt("continueFase") == 1)
        {
            PlayerPrefs.SetInt("continueFase", 2);
        }
        else if (PlayerPrefs.GetInt("continueFase") == 2)
        {
            PlayerPrefs.SetInt("continueFase", 3);
        }
        else if (PlayerPrefs.GetInt("continueFase") == 3)
        {
            PlayerPrefs.SetInt("continueFase", 4);
        }
        else if (PlayerPrefs.GetInt("continueFase") == 4)
        {
            PlayerPrefs.SetInt("continueFase", 5);
        }
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
            SceneManager.LoadScene("FaseQuatro");
        }
        else if (PlayerPrefs.GetInt("continueFase") == 3)
        {
            PlayerPrefs.SetInt("continueFase", 4);
            SceneManager.LoadScene("FaseTres");
        }
        else if (PlayerPrefs.GetInt("continueFase") == 4)
        {
            PlayerPrefs.SetInt("continueFase", 5);
            SceneManager.LoadScene("FaseCinco");
        }else if (PlayerPrefs.GetInt("continueFase") == 5)
        {
            PlayerPrefs.SetInt("continueFase", 1);
            SceneManager.LoadScene("telaPrincipal");
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
