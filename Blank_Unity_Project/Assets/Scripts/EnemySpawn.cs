using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour
{

    public Transform spawnPoint;
    public Transform spawnObject;
    private int spawnTotal = 10;
    public float timeBetweenSpawns;
    // Use this for initialization
    void Start()
    {
        StartCoroutine(SpawnGameObject());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator SpawnGameObject()
    {
        for (var x = 0; x < spawnTotal; x++)
        {
            Instantiate(spawnObject, spawnPoint.position, spawnPoint.rotation);
            yield return new WaitForSeconds(timeBetweenSpawns);
        }
    }
}