using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Indicator_destroy : MonoBehaviour
{
    //public carcontroller Timer;
    public float timer = 5f;

    // Start is called before the first frame update
    void Start()
    {
        timer = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        //Debug.Log("TIMER = " + timer);

        if(timer<0f)
        {
            Destroy(gameObject);
        }
    }
}
