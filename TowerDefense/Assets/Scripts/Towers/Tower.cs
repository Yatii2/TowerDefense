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
    public Transform firePoint; // The point where bullets are fired from
    public GameObject bulletPrefab;

    private float fireCooldown = 0f;
    private List<Transform> enemiesInRange = new List<Transform>();

    private void Update()
    {
        // Fire at enemies in range if the fireCooldown is over
        fireCooldown -= Time.deltaTime;

        enemiesInRange.RemoveAll(e => e == null);

        if (fireCooldown <= 0f && enemiesInRange.Count > 0)
        {
            Shoot(enemiesInRange[0]); // Shoot the first enemy in the list
            fireCooldown = 1f / fireRate; // Reset the cooldown based on fire rate
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            enemiesInRange.Add(other.transform);
            Debug.Log("Enemy entered range: " + other.name);
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

      


        Debug.Log("Shooting at enemy: " + enemy.name);
        GameObject bulletGO = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Bullet bullet = bulletGO.GetComponent<Bullet>();

        if (bullet != null)
        {
            bullet.Seek(enemy);
        }
    }

}
