using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 1f;
    private Transform target;
    private int wavePointIndex = 0;
    private Transform currentWaypoint;
    public float rotationSpeed = 5f;

    private void Start()
    {
        target = Waypoints.points[0];
        //transform.Rotate(0,0,0);
    }

     void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
        RotateTowardsWayPoint();

        if (Vector3.Distance(transform.position, target.position) <= 0.4f)
        {
            GetNextWayPoint();
        }
    }
    void GetNextWayPoint()
    {
        if (wavePointIndex >= Waypoints.points.Length - 1)
        {
            Destroy(gameObject);
            return;
        }
        wavePointIndex++;
        target = Waypoints.points[wavePointIndex];
    }

    private void RotateTowardsWayPoint()
    {
        Vector3 direction = target.position - transform.position;
        Quaternion targetRotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, rotationSpeed);
    }

}
