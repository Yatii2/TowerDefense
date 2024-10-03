using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Collections;
using UnityEngine.Jobs;

public class GameLoopManager : MonoBehaviour
{
   
    public static Queue<Enemy> EnemiesToRemove;
    private static Queue<int> EnemyIDsToSummon;


    public bool LoopShouldEnd;
    private void Start()
    {
        EnemyIDsToSummon = new Queue<int>();
        EnemySpawner.Init();
        EnemiesToRemove = new Queue<Enemy>();

        

        

        StartCoroutine(GameLoop());
        InvokeRepeating("SpawnTest", 0f, 1f);
      

   
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
            //remove
            if(EnemiesToRemove.Count > 0)
            {
                for (int i = 0; i < EnemiesToRemove.Count; i++)
                {
                    EnemySpawner.RemoveEnemy(EnemiesToRemove.Dequeue());
                }
            }


            yield return null;
        }
    }
    public static void EnqueueEnemyIDToSummon(int ID)
    {
        EnemyIDsToSummon.Enqueue(ID);
    }
    public static void EnqueueEnemyToRemove(Enemy EnemyToRemove)
    {
        EnemiesToRemove.Enqueue(EnemyToRemove);
    }
}
