using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptMenuPrincipal : MonoBehaviour {
    private int fase;
    // Use this for initialization
    void Start () {
        fases();
    }
	public void iniciarTutorial(){
        PlayerPrefs.SetInt("continueFase", 1);
        SceneManager.LoadScene("SelecionarPersonagem");
    }
    public void fases()
    {
        fase = PlayerPrefs.GetInt("continueFase");
        fase++;
        Debug.Log(fase);
    }
    public void continueFase()
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
    }
    public void sair(){
		Application.Quit();
	}
	// Update is called once per frame
	void Update () {
		
	}
}
