using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class opcoesMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
        if (PlayerPrefs.GetInt("continueFase") == 1)
        {
            SceneManager.LoadScene("HistoriaUm");
        }else if (PlayerPrefs.GetInt("continueFase") == 2)
        {
            SceneManager.LoadScene("HistoriaDois");
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
