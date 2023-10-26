using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingEnemy : Enemy
{
    [SerializeField] float FlightMultiplier;

    protected override void Start()
    {
        base.Start();
        MaxHP = 3;
        HP = MaxHP;
    }

    protected override void Move()
    {
        transform.Translate(Vector3.up * Mathf.Sin(Time.timeSinceLevelLoad) * FlightMultiplier);
        base.Move();
    }

}
