using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class gameOver : MonoBehaviour {

	public UnityEngine.UI.Text pontos;
	public UnityEngine.UI.Text recorde;
	public UnityEngine.UI.Text moedas;
    public UnityEngine.UI.Text nome;
    private static string _file = "usuario.txt";
    // Use this for initialization
    void Start () {
		pontos.text = PlayerPrefs.GetInt ("pontuacao").ToString ();
		recorde.text = PlayerPrefs.GetInt ("recorde").ToString ();
		moedas.text = PlayerPrefs.GetInt ("moedas").ToString ();
        nome.text = readFile();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
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
