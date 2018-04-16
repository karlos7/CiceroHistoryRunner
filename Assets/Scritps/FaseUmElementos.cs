using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FaseUmElementos : MonoBehaviour {

    //Verifica o chão
    public LayerMask whatIsChao;
    public UnityEngine.UI.Text txtPontos;
    public UnityEngine.UI.Text txtMoedas;
    public bool pause;
    public float escala;
    public AudioClip somFase;
    public AudioSource audioMusic;
    public static FaseUmElementos Instance;
    // Use this for initialization
    void Start () {;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void Awake()
    {
        Instance = this;
    }
}
