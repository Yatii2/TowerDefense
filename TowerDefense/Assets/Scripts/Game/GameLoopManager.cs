using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoopManager : MonoBehaviour
{
    private static Queue<int> EnemyIDsToSummon;
    public bool LoopShouldEnd;
    private void Start()
    {
        EnemyIDsToSummon = new Queue<int>();
        EnemySpawner.Init();

        StartCoroutine(GameLoop());
        InvokeRepeating("SpawnTest", 0f, 1f);
        InvokeRepeating("RemoveTest", 0f, 1.5f);
    }

    void RemoveTest()
    {
        if(EnemySpawner.EnemiesInGame.Count > 0)
        {
            EnemySpawner.RemoveEnemy(EnemySpawner.EnemiesInGame[Random.Range(0, EnemySpawner.EnemiesInGame.Count)]);
        }
    }

    void SpawnTest()
    {
        EnqueueEnemyIDToSummon(1);
    }

    IEnumerator GameLoop()
    {
        while (LoopShouldEnd == false) 
        {
            //spawn
            if (EnemyIDsToSummon.Count > 0)
            {
                for (int i = 0; i < EnemyIDsToSummon.Count; i++) 
                { 
                    EnemySpawner.SpawnEnemy(EnemyIDsToSummon.Dequeue());
                }
            }

            yield return null;
        }
    }
    public static void EnqueueEnemyIDToSummon(int ID)
    {
        EnemyIDsToSummon.Enqueue(ID);
    }
}
