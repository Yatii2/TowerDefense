using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public GameObject cannon;
    private TowerSystem towerSystem;

    private bool hasTower = false;
    //private MoneyManager moneyS;
    //private int cannonCost;


    private void Start()
    {
        towerSystem = FindObjectOfType<TowerSystem>();
        //moneyS = FindObjectOfType<MoneyManager>();
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
    }

    public void CreateTower()
    {
        Instantiate(cannon, transform.position + new Vector3(0, 5.119483f, 0), transform.rotation);
        hasTower = true;
        //moneyS.playerMoney = moneyS.playerMoney - cannonCost;
    }
}
