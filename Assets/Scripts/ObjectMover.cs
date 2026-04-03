using UnityEngine;

public class ObjectMover : MonoBehaviour
{


    [SerializeField] private float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveObject();
    }

    void MoveObject()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }
}
