using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour {

	public Rigidbody2D playerRigidbody;
	public int forceJump;
    public int forceAux;
    public Animator animator;
	public bool slide = true;

	//Verifica o chão
	public Transform groundCheck;
	public bool chao;
	public LayerMask whatIsChao;

	//Moedas
	public Transform moedaCheck;
	public bool moeda;
	public LayerMask whatIsMoeda;
	public static int contCoin = 0;

	//Slide
	public float slideTemp;
	public float timeTemp;

	//Colisor
	public Transform colisor;
    private float vel;
    private float velChao;
    private float velObj;
    private float rate;
    private float rate2;

    // Pontuação

    public static int pontuacao;
	public UnityEngine.UI.Text txtPontos;
	public UnityEngine.UI.Text txtMoedas;
	public GameObject Player;
	public float timePont = 0;

	public AudioSource audio;
	public AudioClip soundJump;
	public AudioClip soundCoin;
	public AudioClip soundSlide;
	public AudioClip soundAlto;
	public AudioClip soundAux;

    public static playerController Instance;
    // Use this for initialization
    void Start () {
		pontuacao = 0;
		playerController.contCoin = 0;
		PlayerPrefs.SetInt ("pontuacao", pontuacao);
        Time.timeScale = 0;
        Player = GameObject.Find("Player") as GameObject;
        txtPontos = GameObject.Find("TxtPontos").GetComponent<UnityEngine.UI.Text>();
        txtMoedas = GameObject.Find("moedass").GetComponent<UnityEngine.UI.Text>();
    }
    void Awake()
    {
        Instance = this;
    }
    // Update is called once per frame
    public void pular(){
		if(chao){
			playerRigidbody.AddForce (new Vector2(0,forceJump));
			audio.PlayOneShot (soundJump);
			audio.volume = 1f;
			if (slide) {
				colisor.position = new Vector3 (colisor.position.x, colisor.position.y + 0.3f, colisor.position.z);
				slide = false;
			}
		}
	}
	public void slde(){
		if(chao && !slide) {
			audio.PlayOneShot (soundSlide);
			audio.volume = 1f;
			colisor.position = new Vector3 (colisor.position.x, colisor.position.y - 0.3f, colisor.position.z);
			slide = true;
			timeTemp = 0;
		}
	}
	void Update () {


		txtPontos.text = pontuacao.ToString ();
		txtMoedas.text = playerController.contCoin.ToString ();
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
				colisor.position = new Vector3(colisor.position.x,colisor.position.y+0.3f, colisor.position.z);
			}
		}

		if (timePont>=0) {
			timePont += Time.deltaTime;
			if(timePont >= 1){
				playerController.pontuacao++;
				timePont = 0;
			}
		}

		animator.SetBool("jump", !chao);
		animator.SetBool("slide", slide);

	}

    void OnTriggerEnter2D(Collider2D collider)
    {
		if (collider.gameObject.tag == "obstaculo") {
			PlayerPrefs.SetInt ("pontuacao", pontuacao);
			PlayerPrefs.SetInt ("moedas", playerController.contCoin);
			if (pontuacao > PlayerPrefs.GetInt ("recorde")) {
				PlayerPrefs.SetInt ("recorde", pontuacao);
			}
            SceneManager.LoadScene("gameOver");
        }
        else
		if (collider.gameObject.tag == "moeda") {
			audio.PlayOneShot (soundCoin);
			audio.volume = 0.5f;
			playerController.contCoin++;
		}
        }
    }
 