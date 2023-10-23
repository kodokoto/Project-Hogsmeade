using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;
    public Rigidbody rb;

    public Vector3 velocity;
    // tag to make immune to the projectile
    public string targetTag;
    //
    void Start()
    {
        rb.velocity = transform.right * speed;
        velocity = rb.velocity;
    }

    void Update()
    {
        // Destroy the projectile if it goes off screen
        if (transform.position.magnitude > 100.0f)
        {
            Destroy(gameObject);
        }
    }

    // Destroy the projectile if it hits an enemy
    void OnTriggerEnter(Collider other)
    {        
        if (other.gameObject.CompareTag(targetTag) )
        {
            other.gameObject.GetComponent<ITakeDamage>().TakeDamage(10);
            Destroy(gameObject);
        } else if (other.gameObject.CompareTag("StickyWall"))
        {
            Destroy(gameObject);
        }
    }
}
