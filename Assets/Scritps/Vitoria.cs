using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class Vitoria : MonoBehaviour {
    // Use this for initialization
    public UnityEngine.UI.Text nome;
    void Start () {
        nome.text = readFile();
    }

    public void sair()
    {
        Application.Quit();
    }

    public void menuPrincipal()
    {
        if (PlayerPrefs.GetInt("continueFase") == 1)
        {
            PlayerPrefs.SetInt("continueFase", 2);
        }
        else if (PlayerPrefs.GetInt("continueFase") == 2)
        {
            PlayerPrefs.SetInt("continueFase", 3);
        }
        else if (PlayerPrefs.GetInt("continueFase") == 3)
        {
            PlayerPrefs.SetInt("continueFase", 4);
        }
        else if (PlayerPrefs.GetInt("continueFase") == 4)
        {
            PlayerPrefs.SetInt("continueFase", 5);
        }
        Time.timeScale = 1;
        SceneManager.LoadScene("telaPrincipal");
    }

    public void voltarJogo()
    {
        if (PlayerPrefs.GetInt("continueFase") == 1)
        {
            PlayerPrefs.SetInt("continueFase", 2);
            SceneManager.LoadScene("FaseDois");
        }
        else if (PlayerPrefs.GetInt("continueFase") == 2)
        {
            PlayerPrefs.SetInt("continueFase", 3);
            SceneManager.LoadScene("FaseQuatro");
        }
        else if (PlayerPrefs.GetInt("continueFase") == 3)
        {
            PlayerPrefs.SetInt("continueFase", 4);
            SceneManager.LoadScene("FaseTres");
        }
        else if (PlayerPrefs.GetInt("continueFase") == 4)
        {
            PlayerPrefs.SetInt("continueFase", 5);
            SceneManager.LoadScene("FaseCinco");
        }else if (PlayerPrefs.GetInt("continueFase") == 5)
        {
            PlayerPrefs.SetInt("continueFase", 1);
            SceneManager.LoadScene("telaPrincipal");
        }
        else
        {
            SceneManager.LoadScene("SelecionarPersonagem");
        }
        playerController.contCoin = 0;
    }
    // Update is called once per frame
    void Update () {
		
	}
    private static string _file = "usuario.txt";
    private static void verifyFile()
    {
        if (!File.Exists(_file))//Verifica se o arquivo existe, retorna true, neguei a condição, então se o arquivo não existir ele entra no IF.
        {
            File.Create(_file);//Cria um arquivo, no caso, cria o arquivo informado na variável _file.
        }
    }
    public static string readFile()
    {

        string textName = ""; //Criamos uma variável que vai armazenar o resultado da nossa consulta no arquivo.

        verifyFile(); //Chamamos novamente nosso método, caso o arquivo não exista ele cria, pois se o arquivo não existir e ele tentar ler vai travar o sistema

        StreamReader streamR = new StreamReader(_file); //Criamos um novo objeto que acessa os métods de leitura, passamos o arquivo que quremos ler.

        textName = streamR.ReadLine(); // Variavel Text recebe a leitura do arquivo.
                                       /*Neste exemplo ele vai ler apenas a primeira linha.
                                        * Caso queria retornar todas, basta usar.
                                        * 
                                           while(streamR.EndOfStream == false){
                                            text += streamR.ReadLine();
                                           }
                                        * 
                                        * Se for retornar todos os valores, o recomendavel é que grave cada linha em um vetor.
                                        */

        streamR.Close(); // Finaliza o uso do nosso arquivo.
        return textName; //Retorna nossa variável com o texto do arquivo.
    }
}
