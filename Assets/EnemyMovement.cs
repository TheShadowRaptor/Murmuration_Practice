using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    private GameObject dest;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        dest = GameObject.Find("Dest");
    }

    // Update is called once per frame
    void Update()
    {
        Look();
        Move();
    }

    private void Look()
    {
        transform.up = dest.transform.position - transform.position;
    }

    private void Move()
    {
        rb.velocity = transform.up * speed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("touching");
        }
    }
}
