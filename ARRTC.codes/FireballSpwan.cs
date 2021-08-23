using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballSpwan : MonoBehaviour
{
    public GameObject FireballObject;
    public float minToCreate = 2f;
    public float maxToCreate = 5f;
    private float timetoNextCreation;
    private float countTimer;
    private float xMin;
    private float xMax;
    // Start is called before the first frame update
    void Start()
    {

        float horizontalExtension = Camera.main.orthographicSize * Screen.width / Screen.height;
        xMin = -horizontalExtension * 0.8f;
        xMax = horizontalExtension * 0.8f;
        
        
        GeneraiteNextTime();
    }

    // Update is called once per frame
    void Update()
    {
        countTimer += Time.deltaTime;
        if(countTimer>= timetoNextCreation)
        {
            countTimer = 0;
            GeneraiteNextTime();

            Vector3 pos = transform.position;
            pos.x = Random.Range(xMin, xMax);
            GameObject.Instantiate(FireballObject, pos, Quaternion.Euler(0,0,0));
        }
    }

    private void GeneraiteNextTime()
    {
        timetoNextCreation = Random.Range(minToCreate, maxToCreate);
    }
}
