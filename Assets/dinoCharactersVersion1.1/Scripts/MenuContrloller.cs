using UnityEngine;
using UnityEngine.SceneManagement;  // Para carregar cenas

public class MenuController : MonoBehaviour
{
    public string nomeCenaJogo = "Fase";

    void Update()
    {
        // Verifica se a tecla "Espaço" foi pressionada
        if (Input.GetKeyDown(KeyCode.Space))
        {
            IniciarJogo();
        }
    }

    // Função para carregar a cena do jogo
    void IniciarJogo()
    {
        
        SceneManager.LoadScene("Fase");
    }
}

