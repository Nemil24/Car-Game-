using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class carcontroller : MonoBehaviour
{
    public Vector3 carPosition;
    public float carSpeed=5f;
    public float rotationSpeed = 10f;
    public float maxLeft, maxRight;
    public float maxBottom, maxTop;
    public Score_Manager scoreValue;
    public float timer = 0f;
    public GameObject gameOverPanel;
    public Vector3 Indicator_pos;
    public GameObject Indicator;
    
    
    // Start is called before the first frame update
    void Start()
    {
        carPosition = transform.position;
        gameOverPanel.SetActive(false);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        carPosition.x += Input.GetAxis("Horizontal") * carSpeed * Time.deltaTime;
        carPosition.y += Input.GetAxis("Vertical") * carSpeed * Time.deltaTime;

        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, -45), rotationSpeed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, 45), rotationSpeed * Time.deltaTime);
        }

        if (transform.rotation.z != 90)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, 0), rotationSpeed * Time.deltaTime);
        }

        carPosition.x = Mathf.Clamp(carPosition.x, maxLeft, maxRight);
        carPosition.y = Mathf.Clamp(carPosition.y, maxBottom, maxTop);

        transform.position = carPosition;
        if(timer>0f)
        {
            timer -= Time.deltaTime;
            Instantiate(Indicator, Indicator_pos, transform.rotation);
        }

        

        //Debug.Log("timer = " + timer);
    }

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Enemy"&&timer<=0f)
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
        }

        if(collision.gameObject.tag=="Coin")
        {
            scoreValue.score_count += 5;
            Destroy(collision.gameObject);
        }

        if(collision.gameObject.tag=="Red")
        {
            scoreValue.score_count -= 20;
            Destroy(collision.gameObject);
        }

        if(collision.gameObject.tag=="Green")
        {
            timer = 5f;
            scoreValue.score_count += 20;
            Destroy(collision.gameObject);
        }
    }
}
