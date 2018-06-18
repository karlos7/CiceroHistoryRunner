using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class SelecionarPersonagem : MonoBehaviour {
    int personagem;
    public Text nomePersonagem;
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
        writeData(nomePersonagem);
    }
    public void voltar()
    {
        SceneManager.LoadScene("telaPrincipal");
    }
    private static string _file = "usuario.txt";

    //Método que cria o arquivo txt caso ele não exista, Void por que não retorna nada.
    private static void verifyFile()
    {
        if (!File.Exists(_file))//Verifica se o arquivo existe, retorna true, neguei a condição, então se o arquivo não existir ele entra no IF.
        {
            File.Create(_file);//Cria um arquivo, no caso, cria o arquivo informado na variável _file.
        }
    }
    public static void writeData(Text nomeP)
    {
        verifyFile(); //Chama nosso método que cria o arquivo caso ele não exista.

        StreamWriter streamW = new StreamWriter(_file);
        /*Criamos um novo objeto do tipo StreamWriter, passamos o nome do nosso arquivo.
         * o true informa que deve continuar gravando no arquivo, isto quer dizer que ele não vai limpar e escrever tudo de novo.
         * Se remover o true toda vez que for gravar uma informação nosso arquivo será limpado e as informações anteriores serão perdidas.
         */

        streamW.WriteLine(nomeP.text);
        /*Através do objeto streamW acessamos o método WriteLine e passamos os textos que queremos gravar.
         * 
         */

        streamW.Close();//Sempre que terminarem de ler e gravar em um arquivo é necessário fecha-lo, isto evita mutios erros.
    }
}
