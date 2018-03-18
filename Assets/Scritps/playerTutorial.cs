using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerTutorial : MonoBehaviour {

	public Rigidbody2D playerRigidbody;
	public int forceJump;
	public Animator animator;
	public bool slide = true;

	//Verifica o chão
	public Transform groundCheck;
	public bool chao;
	public LayerMask whatIsChao;


	//Slide
	public float slideTemp;
	public float timeTemp;


	// Pontuação
	public GameObject Player;

	public AudioSource audio;
	public AudioClip soundJump;
	public AudioClip soundSlide;

	// Use this for initialization
	void Start () {
		Player = GameObject.Find ("Player") as GameObject;
        Time.timeScale = 1;
    }

	// Update is called once per frame
	public void pular(){
		if(chao){
			chao = false;
			playerRigidbody.AddForce (new Vector2(0,forceJump));
			audio.PlayOneShot (soundJump);
			audio.volume = 1f;
			if (slide) {
				slide = false;
			}
		}
	}
	public void slde(){
		if(chao && !slide) {
			audio.PlayOneShot (soundSlide);
			audio.volume = 1f;
			slide = true;
			timeTemp = 0;
		}
	}
	public void pularTurorial(){
		SceneManager.LoadScene("FaseUm");
	}
	void Update () {

		//Se o pulo for apertado e estiver no chão
		if(Input.GetButtonDown("Jump") && chao){
			pular ();
		} 
		if(Input.GetButtonDown("Slide") && chao && !slide){
			slde ();
		} 
		chao = Physics2D.OverlapCircle(groundCheck.position, 0.2f, whatIsChao);
		if (slide) {
			timeTemp += Time.deltaTime;
			if(timeTemp >= slideTemp){
				slide = false;
			}
		}

		animator.SetBool("jump", !chao);
		animator.SetBool("slide", slide);

	}
		
}
