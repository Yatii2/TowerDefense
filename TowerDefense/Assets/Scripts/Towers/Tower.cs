using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public float range = 108.36f;
    public float fireRate = 1f;
    public float damage = 20f;
    public Transform firePoint;
    public GameObject bulletPrefab;

    private float fireCooldown = 0f;
    private List<Transform> enemiesInRange = new List<Transform>();

    private void Update()
    {
        fireCooldown -= Time.deltaTime;

        enemiesInRange.RemoveAll(e => e == null);

        if (fireCooldown <= 0f && enemiesInRange.Count > 0)
        {
            Shoot(enemiesInRange[0]);
            fireCooldown = 1f / fireRate; 
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            enemiesInRange.Add(other.transform);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            enemiesInRange.Remove(other.transform);
        }
    }

    private void Shoot(Transform enemy)
    {
        GameObject bulletGO = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Bullet bullet = bulletGO.GetComponent<Bullet>();

        if (bullet != null)
        {
            bullet.Seek(enemy);
        }
    }

}
