using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Jobs;

public class MoveEnemies : MonoBehaviour
{
    //public Transform NodeParent;
    //public static Vector3[] NodePositions;
    //public bool LoopShouldEnd;
    //private void Start()
    //{
    //    StartCoroutine(GameLoop());
    //    NodePositions = new Vector3[NodeParent.childCount];
    //    for (int i = 0; i < NodePositions.Length; i++)
    //    {
    //        NodePositions[i] = NodeParent.GetChild(i).position;
    //    }
    //}
    //IEnumerator GameLoop()
    //{
    //    while (LoopShouldEnd == false)
    //    {
    //        NativeArray<Vector3> NodesToUse = new NativeArray<Vector3>(NodePositions, Allocator.TempJob);
    //        NativeArray<int> NodeIndices = new NativeArray<int>(EnemySpawner.EnemiesInGame.Count, Allocator.TempJob);
    //        NativeArray<float> EnemySpeeds = new NativeArray<float>(EnemySpawner.EnemiesInGame.Count, Allocator.TempJob);
    //        TransformAccessArray EnemyAcces = new TransformAccessArray(EnemySpawner.EnemiesInGameTransform.ToArray(), 2);


    //        for (int i = 0; i < EnemySpawner.EnemiesInGame.Count; i++)
    //        {
    //            EnemySpeeds[i] = EnemySpawner.EnemiesInGame[i].Speed;
    //            NodeIndices[i] = EnemySpawner.EnemiesInGame[i].NodeIndex;
    //        }

    //        MoveEnemiesJob MoveJob = new MoveEnemiesJob
    //        {
    //            NodePositions = NodesToUse,
    //            EnemySpeed = EnemySpeeds,
    //            NodeIndex = NodeIndices,
    //            deltaTime = Time.deltaTime
    //        };

    //        JobHandle MoveJobHandle = MoveJob.Schedule(EnemyAcces);
    //        MoveJobHandle.Complete();


    //        for(int i = 0; i < EnemySpawner.EnemiesInGame.Count; i++)
    //        {
    //            EnemySpawner.EnemiesInGame[i].NodeIndex = NodeIndices[i];

    //            if(EnemySpawner.EnemiesInGame[i].NodeIndex == NodePositions.Length)
    //            {
    //                EnqueueEnemyToRemove(EnemySpawner.EnemiesInGame[i]);
    //            }
    //        }


    //        NodesToUse.Dispose();
    //        EnemySpeeds.Dispose();
    //        NodeIndices.Dispose();
    //        EnemyAcces.Dispose();


    //        yield return null;
    //    }
    //}

    //public static void EnqueueEnemyToRemove(Enemy EnemyToRemove)
    //{
    //    GameLoopManager.EnemiesToRemove.Enqueue(EnemyToRemove);
    //}
    //public struct MoveEnemiesJob : IJobParallelForTransform
    //{
    //    [NativeDisableParallelForRestriction]
    //    public NativeArray<int> NodeIndex;
    //    public NativeArray<float> EnemySpeed;
    //    public NativeArray<Vector3> NodePositions;
    //    public float deltaTime;
    //    public void Execute(int index, TransformAccess transform)
    //    {
    //        if (NodeIndex[index] < NodePositions.Length)
    //        {
    //            Vector3 PosistionToMoveTo = NodePositions[NodeIndex[index]];
    //            transform.position = Vector3.MoveTowards(transform.position, PosistionToMoveTo, EnemySpeed[index] * deltaTime);

    //            if (transform.position == PosistionToMoveTo)
    //            {
    //                NodeIndex[index]++;
    //            }
    //        }

           
    //    }
    //}
}
