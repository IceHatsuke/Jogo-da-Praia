using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;

public class SaveGame : MonoBehaviour
{
    int pontos;
    int moedas;
    string caminho;

    private void Start()
    {
        autoSave();
    }

    public void SalvarGame()
    {
        //dadosJSON é uma função que vc cria com variaveis de coisas que vc precisa salvar
        DadosJSON dj = new DadosJSON();
        // exemplo dinheiro e alguns bonus
        dj.pontos = pontos;
        dj.moedas = moedas;
        

        // aqui vc pega e cria um json com a função que acabou de fazer
        string json = JsonUtility.ToJson(dj);
        // da nome ao arquivp
        string nomeArquivo = "save_Data.JSON";
        //acha uma pasta para isso usando o comando abaixo
        string pasta = Application.persistentDataPath;
        //e cria o caminho dela, o caminho é a forma que o código vai fazer pra localizar o arquivo q vc criou
        //o caminho, tem a pasta, o lugar onde ela está e o nome do arquivo
        caminho = pasta + Path.AltDirectorySeparatorChar + nomeArquivo;

        // aqui vc escreve as informações no arquivo criado
        File.WriteAllText(caminho, json);
        //esse comando da unity é muito util pq deixa vc escrever em arquivo ou apagar
    }

    void autoSave()
    {
        SalvarGame();
        Invoke("autoSave", 1);
    }

    public void carregaSave()
    {
        // aqui nessa função vc vai fazer basicamente a mesma coisa so ao contrario
        // vai buscar o arquivo pelo nome
        string nomeArquivo = "save_Data.JSON";
        // o local dele
        string pasta = Application.persistentDataPath;
        // o caminho, tem a pasta, o lugar onde ela está e o nome do arquivo
        caminho = pasta + Path.AltDirectorySeparatorChar + nomeArquivo;

        string dados = null;
        //nesse if vc está verificando se existe algum arquivo igual ao "caminho"
        if (File.Exists(caminho))
        {
            //se existe ele vai ler(read) e passar tudo para a variavel dados
            dados = File.ReadAllText(caminho);
        }
        //[{efsdfs}]
        // e aqui vc eta usando o JSONUTILITY para reescrever as coisa de json para as respectivas variaveis
        DadosJSON dj = JsonUtility.FromJson<DadosJSON>(dados);
        //e por ultimo vc passa os valores recebidos do json para as variaveis do seu jogo
        pontos = dj.pontos;
        moedas = dj.moedas;
        
        // PlayerPrefs.DeleteAll();
        //File.Delete(caminho); ---- é para deletar algum arquivo de save
    }

    public void NovoJogo()
    {
        File.Delete(caminho);
    }
}


// precisa disso para fazer o código funcionar
class DadosJSON
{
    public int pontos;
    public int moedas;
}
