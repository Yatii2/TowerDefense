using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int NodeIndex;
    public float MaxHealth;
    public float Health;
    public float Speed;
    public int ID;
    public void Init()
    {
        Health = MaxHealth;
        //transform.position = MoveEnemies.NodePositions[0];
        //NodeIndex = 0;
    }
    
}
