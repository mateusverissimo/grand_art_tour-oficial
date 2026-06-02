using UnityEngine;

public class ControladorPainel : MonoBehaviour
{
    // Arraste o seu Canvas para cá no Inspector da Unity
    public GameObject painelCanvas;

    // Função que o gatilho do VR vai chamar para abrir/fechar a tela
    public void AlternarVisibilidade()
    {
        if (painelCanvas != null)
        {
            painelCanvas.SetActive(!painelCanvas.activeSelf);
        }
    }
}