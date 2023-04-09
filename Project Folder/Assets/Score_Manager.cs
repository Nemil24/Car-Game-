using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score_Manager : MonoBehaviour
{
    public int score_count = 0;
    public int highScore;

    public Text Score_Text;
    public Text HighScore_text;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Score());
        highScore = PlayerPrefs.GetInt("High_score",0 );

        HighScore_text.text = "HIGH SCORE : " + highScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        Score_Text.text = score_count.ToString();

        if(score_count>highScore)
        {
            highScore = score_count;
            PlayerPrefs.SetInt("High_score",  highScore);

        }
    }

    IEnumerator Score()
    {
       while(true)
        {
            yield return new WaitForSeconds(0.8f);
            score_count = score_count + 1;
            //Debug.Log("Score = " + score_count);
        }
    }
}
