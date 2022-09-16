using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : EnemyMovement
{
    private bool flocked;
    private void Update()
    {
        Look();
        Move();
    }
    
    protected void Look()
    {
        if (flocked)
        {
            transform.up = dest.transform.position - transform.position;
        }

        else
        {
            transform.up = enemyHead.transform.position - transform.position;          
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("EnemyHead"))
        {
            flocked = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("EnemyHead"))
        {
            flocked = false;
        }
    }
}
