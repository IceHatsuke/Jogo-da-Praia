using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{ // Fun��o chamada quando o bot�o "Novo Jogo" � clicado
    public void NewGame()
    {
        // Limpa os dados de save anteriores
        DeletePreviousSave();

        // Carrega a pr�xima cena do jogo (voc� pode usar o nome da cena ou seu �ndice na lista de build)
        SceneManager.LoadScene("JogodaPraia");
    }

    // Fun��o chamada quando o bot�o "Continuar" � clicado
    public void ContinueGame()
    {
        // Verifica se existe um save para carregar
        if (SaveExists())
        {
            // Carrega a pr�xima cena do jogo e os dados salvos
            LoadGameData();
            SceneManager.LoadScene("JogodaPraia");
        }
        else
        {
            // Caso n�o haja save para carregar, pode-se iniciar um novo jogo
            NewGame();
        }
    }

    // Fun��o chamada quando o bot�o "Op��es" � clicado
    public void Options()
    {
        // Carrega a cena ou painel de op��es
        // Voc� pode criar uma nova cena ou painel de UI para gerenciar as op��es do jogador
        SceneManager.LoadScene("OptionsScene");
    }

    // Fun��o chamada quando o bot�o "Sair" � clicado
    public void QuitGame()
    {
        // Fecha o jogo
        Application.Quit();
    }

    // Fun��o para limpar o save anterior (implementa��o pode variar)
    private void DeletePreviousSave()
    {
        // Adicione a l�gica para deletar os dados de save anteriores.
        // Isso pode envolver a exclus�o de arquivos de save do jogo ou limpar dados em um sistema de gerenciamento de salvamentos.
    }

    // Fun��o para verificar se existe um save para carregar (implementa��o pode variar)
    private bool SaveExists()
    {
        // Adicione a l�gica para verificar se existem dados salvos.
        // Isso pode envolver a verifica��o da presen�a de arquivos de save ou dados salvos.
        return false; // Retorne true se houver dados de save, ou false caso contr�rio.
    }

    // Fun��o para carregar os dados de save (implementa��o pode variar)
    private void LoadGameData()
    {
        // Adicione a l�gica para carregar os dados de save do jogo.
        // Isso pode envolver a leitura de arquivos de save ou dados salvos e configurando o estado do jogo.
    }


}
