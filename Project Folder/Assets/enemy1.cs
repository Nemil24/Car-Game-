using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy1 : MonoBehaviour
{
    public float enemySpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down * enemySpeed * Time.deltaTime;

        if(transform.position.y< -6.3)
        {
            Destroy(gameObject);
        }
    }
}
