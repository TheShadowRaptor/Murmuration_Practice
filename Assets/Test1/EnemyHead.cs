using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHead : EnemyMovement
{
    private void Update()
    {
        Move();
        Look();
    }

    protected void Look()
    {
        transform.up = dest.transform.position - transform.position;

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {

        }
    }
}
