using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundManager : MonoBehaviour
{
    public GameObject baseEnemyPrefab;
    // public GameObject anotherEnemyPrefab;

    [SerializeField] private int currentRound = 1;
    [SerializeField] private int maxRounds = 5; 
    [SerializeField] private float timeBetweenRounds = 15f; 
    [SerializeField] private int baseEnemyCount;

    private void Start()
    {
        Time.timeScale = 1.0f;
        StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies()
    {
        while (currentRound <= maxRounds)
        {
            int baseEnemyCount = (currentRound == 1) ? 2 : 5;

            for (int i = 0; i < baseEnemyCount; i++)
            {
                Instantiate(baseEnemyPrefab, new Vector3(12.12f, 3.2f, -6.55f), Quaternion.identity);
                
                yield return new WaitForSeconds(2f);
            }

            if (currentRound < maxRounds)
            {
                yield return new WaitForSeconds(timeBetweenRounds);
            }

            currentRound++;
        }

        //als ik nog andere soort enemies wil
        //for (int i = 0; i < ?EnemyCount; i++)
        //{
        //    Instantiate(baseEnemyPrefab, new Vector3(0f, 0f, 0f), Quaternion.identity);
        //    yield return new WaitForSeconds(2f);
        //}
    }
}
