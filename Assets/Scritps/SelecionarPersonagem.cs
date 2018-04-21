using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelecionarPersonagem : MonoBehaviour {
    int personagem;
    public Button sel1;
    public Button sel2;
    public Button sel3;
    public Button sel4;
    public Color c1;
    public Color c2;
    // Use this for initialization
    void Start () {
        personagem = 1;
        ColorBlock cb = sel1.colors;
        cb.normalColor = c1;
        cb.pressedColor = c1;
        cb.highlightedColor = c1;
        sel1.colors = cb;
        sel1.image.color = new Color(113f, 100f, 72f, 245f);
    }
	
	// Update is called once per frame
	void Update () {

	}
    public void p1()
    {
        personagem = 1;
        pp2();
        pp3();
        pp4();
        ColorBlock cb = sel1.colors;
        cb.normalColor = c1;
        cb.pressedColor = c1;
        cb.highlightedColor = c1;
        sel1.colors = cb;
        sel1.image.color = new Color(113f, 100f, 72f, 245f);
    }
    public void p2()
    {
        personagem = 2;
        pp1();
        pp3();
        pp4();
        ColorBlock cb = sel2.colors;
        cb.normalColor = c1;
        cb.pressedColor = c1;
        cb.highlightedColor = c1;
        sel2.colors = cb;
        sel2.image.color = new Color(113f, 100f, 72f, 245f);
    }
    public void p3()
    {
        pp1();
        pp2();
        pp4();
        personagem = 3;
        ColorBlock cb = sel3.colors;
        cb.normalColor = c1;
        cb.pressedColor = c1;
        cb.highlightedColor = c1;
        sel3.colors = cb;
        sel3.image.color = new Color(113f, 100f, 72f, 245f);
    }
    public void p4()
    {
        personagem = 4;
        pp1();
        pp2();
        pp3();
        ColorBlock cb = sel4.colors;
        cb.normalColor = c1;
        cb.pressedColor = c1;
        cb.highlightedColor = c1;
        sel4.colors = cb;
        sel4.image.color = new Color(113f, 100f, 72f, 245f);
    }
    public void pp1()
    {
        ColorBlock cb = sel1.colors;
        cb.normalColor = c2;
        cb.pressedColor = c2;
        cb.highlightedColor = c2;
        sel1.colors = cb;
        sel1.image.color = new Color(113f, 100f, 72f, 120f);
    }
    public void pp2()
    {
        ColorBlock cb = sel2.colors;
        cb.normalColor = c2;
        cb.pressedColor = c2;
        cb.highlightedColor = c2;
        sel2.colors = cb;
        sel2.image.color = new Color(113f, 100f, 72f, 120f);
    }
    public void pp3()
    {
        ColorBlock cb = sel3.colors;
        cb.normalColor = c2;
        cb.pressedColor = c2;
        cb.highlightedColor = c2;
        sel3.colors = cb;
        sel3.image.color = new Color(113f, 100f, 72f, 120f);
    }
    public void pp4()
    {
        ColorBlock cb = sel4.colors;
        cb.normalColor = c2;
        cb.pressedColor = c2;
        cb.highlightedColor = c2;
        sel4.colors = cb;
        sel4.image.color = new Color(113f, 100f, 72f, 120f);
    }
    public void continuar()
    {
        PlayerPrefs.SetInt("personagem", personagem);
        SceneManager.LoadScene("tutorial");
    }
    public void voltar()
    {
        SceneManager.LoadScene("telaPrincipal");
    }
}
