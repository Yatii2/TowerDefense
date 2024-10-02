using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public static List<Enemy> EnemiesInGame;
    public static Dictionary<int, GameObject> EnemyPrefbs;
    public static Dictionary<int, Queue<Enemy>> EnemyObjectPools;

    private static bool IsInitialized;
    public static void Init()
    {
        if (!IsInitialized)
        {
            EnemyPrefbs = new Dictionary<int, GameObject>();
            EnemyObjectPools = new Dictionary<int, Queue<Enemy>>();
            EnemiesInGame = new List<Enemy>();

            EnemyData[] Enemies = Resources.LoadAll<EnemyData>("Enemies");

            foreach (EnemyData enemy in Enemies)
            {
                EnemyPrefbs.Add(enemy.EnemyID, enemy.EnemyPrefab);
                EnemyObjectPools.Add(enemy.EnemyID, new Queue<Enemy>());
            }
            IsInitialized = true;

        }
        else
        {
            Debug.Log("Class already initialized");
        }
        
        

    }
    public static Enemy SpawnEnemy(int EnemyID)
    {
        Enemy SpawnedEnemy = null;

        if (EnemyPrefbs.ContainsKey(EnemyID))
        {
            Queue<Enemy> ReferencedQueue = EnemyObjectPools[EnemyID];
            if (ReferencedQueue.Count > 0)
            {
                SpawnedEnemy = ReferencedQueue.Dequeue();
                SpawnedEnemy.Init();

                SpawnedEnemy.gameObject.SetActive(true);
            }
            else
            {
                GameObject NewEnemy = Instantiate (EnemyPrefbs[EnemyID], Vector3.zero, Quaternion.identity);
                SpawnedEnemy = NewEnemy.GetComponent<Enemy>();
                SpawnedEnemy.Init();
            }
        }
        else
        {
            Debug.Log("No enemy with () ID");
        }
        EnemiesInGame.Add(SpawnedEnemy);
        SpawnedEnemy.ID = EnemyID;
        return SpawnedEnemy;
    }

    public static void RemoveEnemy(Enemy EnemyToRemove)
    {

        EnemyObjectPools[EnemyToRemove.ID].Enqueue(EnemyToRemove);
        EnemiesInGame.Remove(EnemyToRemove);
        EnemyToRemove.gameObject.SetActive(false);
    }


 
}
