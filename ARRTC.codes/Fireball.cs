using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    
    public float minToCreate = 2f;
    public float maxToCreate = 5f;
    private float timetoNextCreation;
    private float countTimer;
    private float xMin;
    private float xMax;
    public GameObject Fire;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        float horizontalExtension = Camera.main.orthographicSize * Screen.width / Screen.height;
        xMin = -horizontalExtension * 0.8f;
        xMax = horizontalExtension * 0.8f;

        GeneraiteNextTime();
    }
    // Update is called once per frame
    void Update()
    {
        countTimer += Time.deltaTime;
        if (countTimer >= timetoNextCreation)
        {
            countTimer = 0;
            GeneraiteNextTime();

            Vector3 pos = transform.position;
            pos.x = Random.Range(xMin, xMax);
            GameObject.Instantiate(Fire, pos, Quaternion.Euler(0, 0, 0));
        }
    }

   
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.name == "Main Camera" || coll.gameObject.tag == "ICE")
        {
            GameObject.Destroy(Fire);
        }
    }
    private void GeneraiteNextTime()
    {
        timetoNextCreation = Random.Range(minToCreate, maxToCreate);
    }
}
