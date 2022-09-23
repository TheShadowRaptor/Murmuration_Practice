using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        other.gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>().color = Color.red;
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        other.gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>().color = Color.white;
    }
}
