using UnityEngine;
using System; // Necesario para [Serializable]

public class AnimationManager : MonoBehaviour
{
    // Creamos una estructura de datos personalizada
    [Serializable]
    public class AnimationControl
    {
        public string nombreIdentificador; // Para que sepas de quién es el botón
        public Animator animator;
        public bool play;
    }

    [Header("Configuración de Animaciones")]
    [SerializeField] private string parameterName = "play";

    // Ahora el arreglo no es de Animators, sino de nuestra clase personalizada
    [SerializeField] private AnimationControl[] animaciones;

    void Update()
    {
        if (animaciones == null || animaciones.Length == 0) return;

        foreach (AnimationControl item in animaciones)
        {
            if (item.animator != null)
            {
                // Cada animator recibe su propio valor de 'play'
                item.animator.SetBool(parameterName, item.play);
            }
        }
    }
}