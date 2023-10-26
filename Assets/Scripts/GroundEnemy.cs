using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundEnemy : Enemy
{
    protected override void Start()
    {
        base.Start();
        MaxHP = 5;
        HP = MaxHP;
    }
}
