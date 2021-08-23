using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Algaspawner : MonoBehaviour
{
    public float maxTime = 1; //tempo de espera do spawn
    private float timer = 0; //contador de tempo
    public GameObject alga; //Objeto
    public float height;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newpipe = Instantiate(alga);
        newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }

    // Update is called once per frame
    void Update()
    {
         if (timer > maxTime)
    {
        GameObject newpipe = Instantiate(alga);
        newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
        Destroy(newpipe, 30);
        timer = 0;
    }

    timer += Time.deltaTime;
    }
}


