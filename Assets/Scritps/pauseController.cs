using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pauseController : MonoBehaviour {
    //Pause
    public GameObject panelPause;
	public GameObject pular;
	public GameObject slide;
    public GameObject panelCuriosidades;
    public GameObject panelHistoria;
    public GameObject panelHistoria2;
    public GameObject panelHistoria3;
    public GameObject botaoHist;
    public UnityEngine.UI.Text texto;
    public GameObject buttonPause;
    private int qtdeHist = 0;
    private float segundos;
    private int fase;
    public static pauseController Instance;
    // Use this for initialization
    void Start () {
        Time.timeScale = 0;
        buttonPause.SetActive(false);
		pular.SetActive (false);
		slide.SetActive (false);
    }
    void Awake()
    {
        Instance = this;
    }
    public void pullar()
    {
        playerController.Instance.pular();
    }
    public void slidee()
    {
        playerController.Instance.slde();
    }
    // Update is called once per frame
    void Update () {
        if (playerController.contCoin >= 100)
        {
            PlayerPrefs.SetInt("moedas", playerController.contCoin);
            panelCuriosidades.SetActive(true);
            fase = PlayerPrefs.GetInt("continueFase")+1;
            PlayerPrefs.SetInt("continueFase", fase);
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
		pular.SetActive (false);
		slide.SetActive (false);
        Pause();
    }

    public void resumeGame()
    {
        panelPause.SetActive(false);
        buttonPause.SetActive(true);
		pular.SetActive (true);
		slide.SetActive (true);
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
		PlayerPrefs.SetInt ("pontuacao", playerController.pontuacao);
		PlayerPrefs.SetInt ("moedas", playerController.contCoin);
		if (playerController.pontuacao > PlayerPrefs.GetInt ("recorde")) {
			PlayerPrefs.SetInt ("recorde", playerController.pontuacao);
		}
		SceneManager.LoadScene("vitoria");
    }
    public void fecharHistoria()
    {
        if(qtdeHist == 0)
        {
            panelHistoria.SetActive(false);
            panelHistoria2.SetActive(true);
            qtdeHist++;
        }
        else if(qtdeHist == 1)
        {
            panelHistoria2.SetActive(false);
            panelHistoria3.SetActive(true);
            texto.text = "Iniciar";
            qtdeHist++;
        }
        else
        {
            panelHistoria3.SetActive(false);
            botaoHist.SetActive(false);
            qtdeHist = 0; ;
            buttonPause.SetActive(true);
			pular.SetActive (true);
			slide.SetActive (true);
            resumeGame();
        }
    }
}
