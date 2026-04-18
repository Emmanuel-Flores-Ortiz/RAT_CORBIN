using UnityEngine;
using UnityEngine.SceneManagement;

public class Cambiador_escenas : MonoBehaviour
{
    public void Cambiar(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }
}