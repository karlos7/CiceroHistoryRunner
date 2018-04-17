using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playerController : MonoBehaviour {

	public Rigidbody2D playerRigidbody;
	public int forceJump;
    public int forceAux;
    public Animator animator;
	public bool slide = true;

	//Verifica o chão
	public Transform groundCheck;
	public bool chao;
    private LayerMask whatIsChao;

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
	public GameObject Player;
	public float timePont = 0;
    public UnityEngine.UI.Text txtPontos;
    public UnityEngine.UI.Text txtMoedas;

    public AudioSource audio;
    public AudioSource audioMusic;
    public AudioClip soundJump;
    public AudioClip somFase;
    public AudioClip soundCoin;
	public AudioClip soundSlide;

    public bool pause;

    public static playerController Instance;
    // Use this for initialization
    void Start () {
        whatIsChao = FaseUmElementos.Instance.whatIsChao;
        txtPontos = FaseUmElementos.Instance.txtPontos;
        txtMoedas = FaseUmElementos.Instance.txtMoedas;
        pause = FaseUmElementos.Instance.pause;
        audioMusic = FaseUmElementos.Instance.audioMusic;
        audio = SonsMusicas.Instance.audio;
        somFase = FaseUmElementos.Instance.somFase;
        pontuacao = 0;
        playerController.contCoin = 0;
		PlayerPrefs.SetInt ("pontuacao", pontuacao);
        if (pause == true) { Time.timeScale = 0; } else { Time.timeScale = 1; }
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
			if (slide) {
				colisor.position = new Vector3 (colisor.position.x, colisor.position.y + 0.3f, colisor.position.z);
				slide = false;
			}
		}
	}
	public void slde(){
		if(chao && !slide) {
			audio.PlayOneShot (soundSlide);
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

		chao = Physics2D.OverlapCircle(groundCheck.position, 0.3f, whatIsChao);
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
			playerController.contCoin++;
		}
        }
    }
 