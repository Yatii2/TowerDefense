using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewEnemy", menuName = "Create Enemy")]
public class EnemyData : ScriptableObject
{
    public GameObject EnemyPrefab;
    public int EnemyID;
 
}
