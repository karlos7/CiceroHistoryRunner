using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerTutorial : MonoBehaviour {
    public static playerTutorial Instance;
    void Start () {
    }
	public void pularTurorial(){
		SceneManager.LoadScene("HistoriaUm");
	}
    public void voltar()
    {
        SceneManager.LoadScene("SelecionarPersonagem");
    }
    void Update () {

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
}
