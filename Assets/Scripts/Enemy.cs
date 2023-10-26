using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
[RequireComponent(typeof(Rigidbody))]
public class Enemy : Entity
{
    [SerializeField] float MovementSpeed;

    Rigidbody rb;

    protected virtual void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Move();
    }

    protected virtual void Move()
    {
        rb.AddForce(Vector3.left * MovementSpeed);
    }
}
