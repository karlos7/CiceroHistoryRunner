using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPlayer : MonoBehaviour {

    public GameObject Player;
    private GameObject PlayerJogo;
    public GameObject Player2;
    public GameObject Player3;
    public GameObject Player4;
    public float x;
    public float y;
    public float escala;
    public static spawnPlayer Instance;

    // Use this for initialization
    void Start () {
        escala = FaseUmElementos.Instance.escala;
        if (PlayerPrefs.GetInt("personagem") == 1)
        {
            PlayerJogo = Instantiate(Player) as GameObject;
            PlayerJogo.transform.position = new Vector3(x, y, -3f);
            PlayerJogo.gameObject.transform.localScale = new Vector3(escala, escala, escala);
        }
        else if (PlayerPrefs.GetInt("personagem") == 2)
        {
            PlayerJogo = Instantiate(Player2) as GameObject;
            PlayerJogo.transform.position = new Vector3(x, y, -3f);
            PlayerJogo.gameObject.transform.localScale = new Vector3(escala, escala, escala);
        }
        else if (PlayerPrefs.GetInt("personagem") == 3)
        {
            PlayerJogo = Instantiate(Player3) as GameObject;
            PlayerJogo.transform.position = new Vector3(x, y, -3f);
            PlayerJogo.gameObject.transform.localScale = new Vector3(escala, escala, escala);
        }
        else
        {
            PlayerJogo = Instantiate(Player4) as GameObject;
            PlayerJogo.transform.position = new Vector3(x, y, -3f);
            PlayerJogo.gameObject.transform.localScale = new Vector3(escala, escala, escala);
        }
    }
    void Awake()
    {
        Instance = this;
    }
    // Update is called once per frame
    void Update () {
		
	}
}
