using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class road : MonoBehaviour
{
    public float scrollSpeed;
    Vector3 initialPosition;
    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y>(initialPosition + new Vector3(0,-200,0)).y)
        {
            transform.position += Vector3.down * scrollSpeed * Time.deltaTime;
        }
        else
        {
            transform.position=initialPosition;
        }
    }
}
