using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Game_Controller : MonoBehaviour
{
    public Text scoreText;
    public int score;

    public Score_Manager score_manager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score = score_manager.score_count;

        scoreText.text = "Score :  "+score.ToString();

    }

    public void Restart()
    {
        SceneManager.LoadScene("SampleScene"); 
    }
}
