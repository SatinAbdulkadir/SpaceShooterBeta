using UnityEngine;

public class EnemyDamageController : MonoBehaviour
{
    [SerializeField] private int damageCount;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerHealth.instance.TakeDamage(damageCount);
            Destroy(gameObject);
           

        }
       
    }
}
