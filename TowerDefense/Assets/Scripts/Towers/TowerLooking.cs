using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerLooking : MonoBehaviour
{
    public Transform targetEnemy;
    public float rotationSpeed = 5f; 

    private void Update()
    {
        if (targetEnemy != null)
        {

            Vector3 direction = targetEnemy.position - transform.position;
            direction.y = 0;

            Quaternion targetRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
    }

    public void SetTarget(Transform newTarget)
    {
        targetEnemy = newTarget;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            SetTarget(other.transform);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            targetEnemy = null;
        }
    }
}
