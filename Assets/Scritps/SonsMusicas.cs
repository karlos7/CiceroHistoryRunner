using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SonsMusicas : MonoBehaviour {

    public AudioSource audio;
    private AudioSource audioMusic;
    private AudioClip somFase;
    public Image buttonMusic;
    public Image buttonAudio;
    public Sprite MusicOnImg;
    public Sprite MusicOffImg;
    public Sprite AudioOnImg;
    public Sprite AudioOffImg;
    public int cont = 0;
    public static SonsMusicas Instance;
    // Use this for initialization
    void Start()
    {
        audioMusic = FaseUmElementos.Instance.audioMusic;
        somFase = FaseUmElementos.Instance.somFase;
        if (PlayerPrefs.GetInt("music") == 2)
        {
            buttonMusic.sprite = MusicOnImg;
        }
        else if(PlayerPrefs.GetInt("audio") == 1)
        {
            buttonMusic.sprite = MusicOffImg;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    void Awake()
    {
        Instance = this;
    }
    public void playMusica()
    {
        audioMusic.clip = somFase;
        audioMusic.loop = true;
        audioMusic.Play();
    }
    public void musicOn()
    {
        if (cont==0)
        {
            playMusica();
            cont = 1;
        }
        else if (PlayerPrefs.GetInt("music") != 1 && cont != 0)
        {
            PlayerPrefs.SetInt("music", 1);
            audioMusic.Play();
            buttonMusic.sprite = MusicOnImg;
        }
        else
        {
            PlayerPrefs.SetInt("music", 2);
            audioMusic.Pause();
            buttonMusic.sprite = MusicOffImg;
        }
    }
    public void audioOn()
    {
        if (PlayerPrefs.GetInt("audio") != 1)
        {
            PlayerPrefs.SetInt("audio", 1);
            audio.volume = 0.7f;
            buttonAudio.sprite = AudioOnImg;
        }
        else
        {
            PlayerPrefs.SetInt("audio", 2);
            audio.volume = 0.0f;
            buttonAudio.sprite = AudioOffImg;
        }
    }
}
