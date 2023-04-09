using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps_Spawner : MonoBehaviour
{
    public GameObject[] PowerUps;
    public float maxLeft;
    public float maxRight;
    public float delayTimer = 5f;
    float timer;
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

        if (timer <= 0)
        {
            //Vector3 spawnPos = new Vector3(Random.Range(maxLeft, maxRight), transform.position.y, transform.position.z);

            int randomIndex = Random.Range(0, 2);
            //Vector3 spawnPos = new Vector3(Random.Range(maxLeft, maxRight), transform.position.y, transform.position.z);  
            int i = Random.Range(0, 3);

            Instantiate(PowerUps[randomIndex], spawnPos[i], transform.rotation);
            timer = delayTimer;
        }
    }
}
