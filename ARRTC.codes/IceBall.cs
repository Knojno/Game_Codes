using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceBall : MonoBehaviour
{
    
    public float Speed = 5f;
    public GameObject Ice;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

   
    void FixedUpdate()
    {
        rb.velocity = Vector2.up * Speed;
    }

   
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.name == "Main Camera" || coll.gameObject.tag == "FIRE")
        {
            GameObject.Destroy(Ice);
        }
    }

}
