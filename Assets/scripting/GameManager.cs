using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public bool ispaused;
    public GameObject[] bird;
    public GameObject[] birdLeft;

    public int score = 0;
   
    public Text highScoreText;
    public Text scoreText;
    public Text Timer;
    public float timeLeft;
    bool win = false;
    public GameObject GameOverPanel ;

    public GlobalValues GValues;

    void Start()
    {
        Time.timeScale = 1f;
        highScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();   
        InvokeRepeating("spawn",1f,1f);
 
    }

    void Update()
    {
        if (win == true)
        {
            CancelInvoke("spawn");
        }
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<AudioSource>().Play();
        }

        timeLeft -= Time.deltaTime;
        Timer.text = "" + Mathf.Round(timeLeft);

        if (timeLeft <= 0)
        {
            timeLeft = 0;
            //SceneManager.LoadScene("Gameover");
            GameOverPanel.SetActive(true);
            Time.timeScale = 0f;
            gameObject.GetComponent<AudioSource>().enabled = false;
        }

    }
    void spawn()
    {
        float randomX = Random.Range(-27f, -26f);
        
        float randomY = Random.Range(7.0f, -7.0f);

        float randomLeftX = Random.Range(27f, 26f);
        float randomLeftY = Random.Range(7f, -7f);

        Vector3 randomPosition = new Vector3(randomX, randomY, 0);
        Vector3 randomPositionLeft = new Vector3(randomLeftX, randomLeftY, 0);

        Instantiate(bird[Random.Range(0,bird.Length)], randomPosition, Quaternion.identity);
        Instantiate(birdLeft[Random.Range(0, birdLeft.Length)], randomPositionLeft, Quaternion.identity);
        
    }
     public void IncrementScore()
    {
        score++;
        scoreText.text = score.ToString();

        if(score > PlayerPrefs.GetInt("HighScore",0))
        {
            PlayerPrefs.SetInt("HighScore", score);
            highScoreText.text = score.ToString();
        }
        
        for(int i=0; i<=score; i++)
        {
            GValues.increaseMoveSpeed();
        }
    }

    public void incrementTime()
    {
        timeLeft += 1.5f;
    }

    public void decrementTime()
    {
        timeLeft -= 5f;
    }

}



