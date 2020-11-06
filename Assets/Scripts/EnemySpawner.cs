using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private List<Enemy> enemyPrefab;
    private bool canSpawn = true;
    private float minSpawnTime = 1f;
    private float maxSpawnTime = 5f;
    
    IEnumerator Start()
    {
        while (canSpawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnTime,maxSpawnTime));
            Spawn();
        }
    }

    private void Spawn()
    {
        Instantiate(enemyPrefab[0],transform.position,Quaternion.identity);
    }
}
