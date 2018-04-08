using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPlayer : MonoBehaviour {

    public GameObject Player;
    private GameObject PlayerJogo;
    public GameObject Player2;
    public GameObject Player3;
    public GameObject Player4;

    // Use this for initialization
    void Start () {
        if (PlayerPrefs.GetInt("personagem") == 1)
        {
            PlayerJogo = Instantiate(Player) as GameObject;
            PlayerJogo.transform.position = new Vector3(-42.34f, 9f, -3f);
        }
        else if (PlayerPrefs.GetInt("personagem") == 2)
        {
            PlayerJogo = Instantiate(Player2) as GameObject;
            PlayerJogo.transform.position = new Vector3(-42.34f, 9f, -3f);
        }
        else if (PlayerPrefs.GetInt("personagem") == 3)
        {
            PlayerJogo = Instantiate(Player3) as GameObject;
            PlayerJogo.transform.position = new Vector3(-42.34f, 9f, -3f);
        }
        else
        {
            PlayerJogo = Instantiate(Player4) as GameObject;
            PlayerJogo.transform.position = new Vector3(-42.34f, 9f, -3f);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
