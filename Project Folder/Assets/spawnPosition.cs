using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPosition : MonoBehaviour
{
    public GameObject[] enemyCar;
    public float maxLeft;
    public float maxRight;
    public float delayTimer = 1f;
    public float stoptime = 0f;
    public float timer;
    public Vector3[] spawnPos;
    // Start is called before the first frame update
    void Start()
    {
       timer = delayTimer;
       
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;


        

        if(timer<=0)
        {
            //Vector3 spawnPos = new Vector3(Random.Range(maxLeft, maxRight), transform.position.y, transform.position.z);
            
            int randomIndex = Random.Range(0, 2);
            int i = Random.Range(0, 3);

            Instantiate(enemyCar[randomIndex], spawnPos[i], transform.rotation);
            timer = delayTimer;
        }
    }
}
