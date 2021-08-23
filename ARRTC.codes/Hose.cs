using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Globalization;



public class Hose : MonoBehaviour
{
    public FixedJoystick moveJoystick;
    private Rigidbody2D rb;
    public GameObject Ice;
    public float Speed = 4;
    private float shootTimer = 0;
    public float MinTimeToShoot = 1f;
    public float moveH;
   
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    
    
    
    
    void Update()
    {

        MovePlayer();
        if (shootTimer < MinTimeToShoot)
        {
            shootTimer += Time.deltaTime;
        }
        
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    /*private void FixedUpdate()
    {
        Vector2 dir = Vector2.zero;
        
       
    } */
    private void MovePlayer()
    {
        
        moveH = moveJoystick.Horizontal;
        Vector3 dir = new Vector3(moveH, 0, 0);
        rb.velocity = new Vector3 (moveH*Speed, 0, 0);
        if (Input.GetKey(KeyCode.A))
        {
            dir.x = -1;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            dir.x = 1;
        }
        rb.velocity = dir * Speed;
    }
    public void Shoot()
    {
        if (MinTimeToShoot > shootTimer)
        {
            return;
        }

        shootTimer = 0;
        if (Ice != null)
        {
            Vector3 pos = this.transform.position;
            pos.y = +0.1f;
            GameObject.Instantiate(Ice, pos, Quaternion.identity);
        }
    }
}
