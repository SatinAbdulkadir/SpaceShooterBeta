using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform[] hedefler;
    public float moveSpeed = 5f;

    private int currentTargetIndex = 0;

    private void Update()
    {
        if (hedefler.Length==0)
        {
            return;
        }

        transform.position = Vector3.MoveTowards(transform.position,hedefler[currentTargetIndex].position, moveSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, hedefler[currentTargetIndex].position)<0.1f)
        {
            currentTargetIndex++;

           if (currentTargetIndex>=hedefler.Length)
            {
                currentTargetIndex = 0;
                transform.position=hedefler[currentTargetIndex].position;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerBullet"))
        {
         Destroy(collision.gameObject);
         Destroy(gameObject);
            
        }
    }

}
