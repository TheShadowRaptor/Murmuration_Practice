using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    private float playerHorizontalVelocity;
    private float playerVerticalVelocity;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    private void move()
    {
        playerHorizontalVelocity = Input.GetAxis("Horizontal");
        playerVerticalVelocity = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(playerHorizontalVelocity * speed, playerVerticalVelocity * speed, 0);
    }
}
