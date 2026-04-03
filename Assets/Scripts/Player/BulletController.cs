using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] private float bulletSpeed;
    [SerializeField] GameObject destroyMeteorEffect;

    private void Update()
    {
        transform.Translate(Vector3.up * bulletSpeed*Time.deltaTime);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.CompareTag("Meteor"))
        {
            Instantiate(destroyMeteorEffect, transform.position, Quaternion.identity);

            Destroy(collision.gameObject);

        }

    }
}
