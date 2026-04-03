using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerHealth : MonoBehaviour
{
    public static PlayerHealth instance;

    [SerializeField] private int maxHealth=10;
    public int currentHealth;

    public int MaxHealth => maxHealth;

    private void Start()
    {
        currentHealth = maxHealth;
        PlayerHealthUIManager.instance.PlayerHealthDisplay();
    }

    private void Awake()
    {
       instance = this;
    }

    public void TakeDamage(int damageValue)
    {
        currentHealth-=damageValue;

        currentHealth=math.clamp(currentHealth,0,maxHealth);

        PlayerHealthUIManager.instance.PlayerHealthDisplay();

        if (currentHealth<=0)
        {
            gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        if (Keyboard.current.qKey.wasPressedThisFrame) 
        {
            TakeDamage(2);
        }

        

       

    }
}
