using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public GameObject cannon;
    private TowerSystem towerSystem;
    private bool hasTower = false;

    [SerializeField] private AudioClip placeAudio;
    private AudioSource audioSource;
    //private MoneyManager moneyS;
    //private int cannonCost;


    private void Start()
    {
        towerSystem = FindObjectOfType<TowerSystem>();
        //moneyS = FindObjectOfType<MoneyManager>();

        audioSource = GetComponent<AudioSource>();
    }
     private void Update()
    {
        cannon = towerSystem.chooseCannon;
        //cannonCost = towerSystem.cannonToBuildCost;
    }
    private void OnMouseDown()
    {
        if (hasTower)
        {
            return;
        }

        
        CreateTower();
        audioSource.clip = placeAudio;
        audioSource.Play();
    }

    public void CreateTower()
    {
        Instantiate(cannon, transform.position + new Vector3(0, 5.119483f, 0), transform.rotation);
        hasTower = true;
        //moneyS.playerMoney = moneyS.playerMoney - cannonCost;
    }
}
