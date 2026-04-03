using System;
using UnityEngine;

public class BackGorundRepeating : MonoBehaviour
{

    [SerializeField] private float height;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y<-height)
        {
            PozisyonuGuncelle();
        }
    }

    private void PozisyonuGuncelle()
    {
        Vector2 pos = new Vector2(0, height * 2);
        transform.position = (Vector2)transform.position + pos; 
    }
}
