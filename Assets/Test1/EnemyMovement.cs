using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    protected Rigidbody2D rb;

    public GameObject dest;
    public GameObject enemyHead;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        dest = GameObject.Find("Dest");
        enemyHead = GameObject.Find("EnemyHead");
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("touching");
        }
    }
    protected void Move()
    {
        rb.AddForce(transform.up * speed);
    }
}
