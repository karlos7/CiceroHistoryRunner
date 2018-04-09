using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaseUmElementos : MonoBehaviour {

    //Verifica o chão
    public LayerMask whatIsChao;
    public UnityEngine.UI.Text txtPontos;
    public UnityEngine.UI.Text txtMoedas;
    public bool pause;
    public float escala;
    public static FaseUmElementos Instance;
    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void Awake()
    {
        Instance = this;
    }
}
