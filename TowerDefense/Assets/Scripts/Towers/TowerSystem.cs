using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSystem : MonoBehaviour
{
    public GameObject weakCannon;
    public GameObject mediumCannon;
    public GameObject strongCannon;

    public GameObject chooseCannon;
    public int cannonToBuildCost;

    private MoneyManager moneyS;
    public int currentMoney;
    private int weakCannonCost = 100;
    private int mediumCannonCost = 500;
    private int strongCannonCost = 1000;
    

    public void Start()
    {
        moneyS = FindObjectOfType<MoneyManager>();
    }

    public void weakCannonSelected() 
    {
        chooseCannon = weakCannon;
        cannonToBuildCost = weakCannonCost;
    }

    public void mediumCannonSelected()
    {
        chooseCannon = mediumCannon;
        cannonToBuildCost = mediumCannonCost;
    }

    public void strongCannonSelected()
    {
        chooseCannon = strongCannon;
        cannonToBuildCost = strongCannonCost;
    }

    public void Update()
    {
        currentMoney = moneyS.playerMoney;

        if (currentMoney <= weakCannonCost && chooseCannon == weakCannon)
        {
            chooseCannon = null;
        }
        if (currentMoney <= mediumCannonCost && chooseCannon == mediumCannon)
        {
            chooseCannon = null;
        }
        if (currentMoney <= strongCannonCost && chooseCannon == strongCannon)
        {
            chooseCannon = null;
        }
    }

}
