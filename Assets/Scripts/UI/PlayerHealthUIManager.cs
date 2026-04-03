using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthUIManager : MonoBehaviour
{

    public static PlayerHealthUIManager instance;
    [SerializeField] private Image healthImageFill;
    
    private void Awake()
    {
        instance = this;
    }

    public void PlayerHealthDisplay()
    {
        float current = (float)PlayerHealth.instance.currentHealth;
        float max = (float)PlayerHealth.instance.MaxHealth;

        healthImageFill.fillAmount = current / max;

    }
}
