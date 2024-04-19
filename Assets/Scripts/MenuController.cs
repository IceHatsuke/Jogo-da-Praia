using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{ // Função chamada quando o botão "Novo Jogo" é clicado
    public void NewGame()
    {
        // Limpa os dados de save anteriores
        DeletePreviousSave();

        // Carrega a próxima cena do jogo (você pode usar o nome da cena ou seu índice na lista de build)
        SceneManager.LoadScene("JogodaPraia");
    }

    // Função chamada quando o botão "Continuar" é clicado
    public void ContinueGame()
    {
        // Verifica se existe um save para carregar
        if (SaveExists())
        {
            // Carrega a próxima cena do jogo e os dados salvos
            LoadGameData();
            SceneManager.LoadScene("JogodaPraia");
        }
        else
        {
            // Caso não haja save para carregar, pode-se iniciar um novo jogo
            NewGame();
        }
    }

    // Função chamada quando o botão "Opções" é clicado
    public void Options()
    {
        // Carrega a cena ou painel de opções
        // Você pode criar uma nova cena ou painel de UI para gerenciar as opções do jogador
        SceneManager.LoadScene("OptionsScene");
    }

    // Função chamada quando o botão "Sair" é clicado
    public void QuitGame()
    {
        // Fecha o jogo
        Application.Quit();
    }

    // Função para limpar o save anterior (implementação pode variar)
    private void DeletePreviousSave()
    {
        // Adicione a lógica para deletar os dados de save anteriores.
        // Isso pode envolver a exclusão de arquivos de save do jogo ou limpar dados em um sistema de gerenciamento de salvamentos.
    }

    // Função para verificar se existe um save para carregar (implementação pode variar)
    private bool SaveExists()
    {
        // Adicione a lógica para verificar se existem dados salvos.
        // Isso pode envolver a verificação da presença de arquivos de save ou dados salvos.
        return false; // Retorne true se houver dados de save, ou false caso contrário.
    }

    // Função para carregar os dados de save (implementação pode variar)
    private void LoadGameData()
    {
        // Adicione a lógica para carregar os dados de save do jogo.
        // Isso pode envolver a leitura de arquivos de save ou dados salvos e configurando o estado do jogo.
    }


}
