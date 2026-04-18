using UnityEngine;

public class Animator_play : MonoBehaviour
{
    [Header("Animators de las imágenes")]
    [SerializeField] private Animator[] animators;

    [Header("Nombre del parámetro en el Animator")]
    [SerializeField] private string parameterName = "play";

    [Header("Activar animaciones")]
    [SerializeField] private bool playAnimations = true;

    void Start()
    {
        UpdateAnimators();
    }

    void Update()
    {
        UpdateAnimators();
    }

    private void UpdateAnimators()
    {
        if (animators == null || animators.Length == 0) return;

        foreach (Animator anim in animators)
        {
            if (anim != null)
            {
                anim.SetBool(parameterName, playAnimations);
            }
        }
    }
}