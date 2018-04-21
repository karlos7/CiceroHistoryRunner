using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spawnController : MonoBehaviour {


	public GameObject barreiraPrefab1;
	public GameObject barreiraPrefab2;
	public static float rateSpawn = 4;
    public static float rateSpawn2 = 5;
    public float currentTime;
    private int posicao;
    private float y;
	public static GameObject tempPrefab;
    public static GameObject tempPrefab15;

    //Moedas
    public GameObject moedaPrefab1;
	public static GameObject tempPrefab1;
	public GameObject moedaPrefab2;
	private GameObject tempPrefab2;
	public GameObject moedaPrefab3;
	private GameObject tempPrefab3;
	public GameObject moedaPrefab4;
	private GameObject tempPrefab4;
	public GameObject moedaPrefab5;
	private GameObject tempPrefab5;
	public GameObject moedaPrefab6;
	private GameObject tempPrefab6;
    public GameObject moedaPrefab7;
    private GameObject tempPrefab7;
    public GameObject moedaPrefab8;
    private GameObject tempPrefab8;
    public GameObject moedaPrefab9;
    private GameObject tempPrefab9;
    public GameObject moedaPrefab10;
    private GameObject tempPrefab10;
    private float x;



    // Use this for initialization
    void Start () {
		currentTime = 0;
    }
    public void Rate()
    {
        rateSpawn = Random.Range(rateSpawn, rateSpawn2);
    }
    // Update is called once per frame
    void Update () {



		currentTime += Time.deltaTime;
		if (currentTime >= rateSpawn) {
            Rate();
			currentTime = 0;
            posicao = Random.Range(0, 100);
            if (posicao >= 0 && posicao < 30) {
                y = 8.32f;
                tempPrefab = Instantiate(barreiraPrefab1) as GameObject;
                tempPrefab.transform.position = new Vector3(transform.position.x, tempPrefab.transform.position.y, tempPrefab.transform.position.z);
            } else if (posicao >= 30 && posicao < 60) {
                y = 9.3f;
                tempPrefab15 = Instantiate(barreiraPrefab2) as GameObject;
                tempPrefab15.transform.position = new Vector3(transform.position.x, y, tempPrefab15.transform.position.z);
            }
              else if (posicao >= 60 && posicao < 80) {
                y = 9.6f;
                x = transform.position.x;
                tempPrefab1 = Instantiate(moedaPrefab1) as GameObject;
                tempPrefab2 = Instantiate(moedaPrefab2) as GameObject;
                tempPrefab3 = Instantiate(moedaPrefab3) as GameObject;
                tempPrefab4 = Instantiate(moedaPrefab4) as GameObject;
                tempPrefab5 = Instantiate(moedaPrefab5) as GameObject;
                tempPrefab6 = Instantiate(moedaPrefab6) as GameObject;
                tempPrefab7 = Instantiate(moedaPrefab7) as GameObject;
                tempPrefab8 = Instantiate(moedaPrefab8) as GameObject;
                tempPrefab9 = Instantiate(moedaPrefab9) as GameObject;
                tempPrefab10 = Instantiate(moedaPrefab10) as GameObject;

                /*
                Formato das Moedas

                     O  O      O  O  O
                     O  O      O  O  O

             */
                tempPrefab1.transform.position = new Vector3(x, y, tempPrefab1.transform.position.z);
                x += 0.5f;
                tempPrefab2.transform.position = new Vector3(x, y, tempPrefab2.transform.position.z);
                x += 1.5f;
                tempPrefab3.transform.position = new Vector3(x, y, tempPrefab3.transform.position.z);
                x += 0.5f;
                tempPrefab4.transform.position = new Vector3(x, y, tempPrefab4.transform.position.z);
                x += 0.5f;
                tempPrefab5.transform.position = new Vector3(x, y, tempPrefab5.transform.position.z);
                y += 0.5f;
                tempPrefab6.transform.position = new Vector3(x, y, tempPrefab6.transform.position.z);
                x -= 0.5f;
                tempPrefab7.transform.position = new Vector3(x, y, tempPrefab7.transform.position.z);
                x -= 0.5f;
                tempPrefab8.transform.position = new Vector3(x, y, tempPrefab8.transform.position.z);
                x -= 1.5f;
                tempPrefab9.transform.position = new Vector3(x, y, tempPrefab9.transform.position.z);
                x -= 0.5f;
                tempPrefab10.transform.position = new Vector3(x, y, tempPrefab10.transform.position.z);
            }
            else if (posicao >= 80 && posicao < 100) {
                y = 9.6f;
                x = transform.position.x;
                tempPrefab1 = Instantiate(moedaPrefab1) as GameObject;
                tempPrefab2 = Instantiate(moedaPrefab2) as GameObject;
                tempPrefab3 = Instantiate(moedaPrefab3) as GameObject;
                tempPrefab4 = Instantiate(moedaPrefab4) as GameObject;
                tempPrefab5 = Instantiate(moedaPrefab5) as GameObject;
                tempPrefab6 = Instantiate(moedaPrefab6) as GameObject;
                tempPrefab7 = Instantiate(moedaPrefab7) as GameObject;
                tempPrefab8 = Instantiate(moedaPrefab8) as GameObject;
                tempPrefab9 = Instantiate(moedaPrefab9) as GameObject;
                tempPrefab10 = Instantiate(moedaPrefab10) as GameObject;

                /*
			  	Formato das Moedas

						 O
				  	   O   O
				 	 O   O   O
			 	
			 */
                tempPrefab1.transform.position = new Vector3(x, y, tempPrefab1.transform.position.z);
                x += 0.6f;
                tempPrefab2.transform.position = new Vector3(x, y, tempPrefab2.transform.position.z);
                x += 0.6f;
                tempPrefab3.transform.position = new Vector3(x, y, tempPrefab3.transform.position.z);
                x += 1.8f;
                tempPrefab4.transform.position = new Vector3(x, y, tempPrefab4.transform.position.z);
                x += 0.6f;
                tempPrefab5.transform.position = new Vector3(x, y, tempPrefab5.transform.position.z);
                x += 0.6f;
                tempPrefab6.transform.position = new Vector3(x, y, tempPrefab6.transform.position.z);
                y += 0.5f;
                x -= 0.3f;
                tempPrefab7.transform.position = new Vector3(x, y, tempPrefab7.transform.position.z);
                x -= 0.6f;
                tempPrefab8.transform.position = new Vector3(x, y, tempPrefab8.transform.position.z);
                x -= 2.4f;
                tempPrefab9.transform.position = new Vector3(x, y, tempPrefab9.transform.position.z);
                x -= 0.6f;
                tempPrefab10.transform.position = new Vector3(x, y, tempPrefab10.transform.position.z);
            }
				
		}
    }

}
