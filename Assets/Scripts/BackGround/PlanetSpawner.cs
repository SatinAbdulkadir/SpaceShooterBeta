using System.Collections;
using UnityEngine;

public class PlanetSpawner : MonoBehaviour
{
    [Header("Ayarlar")]
    [SerializeField] private float horizontalRange = 2.7f;
    [SerializeField] private float throwYPos = 12f;
    [SerializeField] private float throwDelay = 1f;


    [Header("Elements")]
    [SerializeField] private GameObject[] planetPrefabs;


    private void Start()
    {
        StartCoroutine(ThrowPlaneRouitne());
    }

    IEnumerator ThrowPlaneRouitne()
    {
        while (true) 
        {
            float randomX = Random.Range(-horizontalRange, horizontalRange);
            Vector3 throwPos = new Vector3(randomX, throwYPos,0);

            int randomIndex=Random.Range(0,planetPrefabs.Length);
            GameObject planetPrefab=Instantiate(planetPrefabs[randomIndex], throwPos,Quaternion.identity);

            Destroy(planetPrefab, 30f); 

            yield return new WaitForSeconds(throwDelay);
        }

    }



}
