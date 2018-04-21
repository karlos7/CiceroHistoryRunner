using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pularHistoria : MonoBehaviour {
    public GameObject histUm;
    public GameObject histDois;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private int pularhist = 0;
    public void pularH(){

        if (pularhist == 0)
        {
            pularhist += 1; ;
            histUm.SetActive(false);
            histDois.SetActive(true);
        }
        else if (pularhist == 1)
        {
            pularhist += 1; ;
            SceneManager.LoadScene("FaseUm");
        }
    }
}
