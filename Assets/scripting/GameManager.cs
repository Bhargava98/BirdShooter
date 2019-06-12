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

    public List<GameObject> Birds = new List<GameObject>();
    public int CountVal = 10;

    void SpawnCount(int Count)
    {
        for (int i = 0; i < Count; i++) { 
            GameObject Obj = Instantiate(bird[Random.Range(0,4)], new Vector3(-35f, 0f, 0f), Quaternion.identity);
            Obj.SetActive(false);
            Birds.Add(Obj);
        }
     }

    void Start()
    {
        //init
        SpawnCount(CountVal);


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
        int randomX = Random.Range(0, 2);

        float RandPosX = 0f;
        float RandPosY = Random.Range(7f, -7f);

        
        int TempVal = Random.Range(0, Birds.Count);
        GameObject TempObj = Birds[TempVal];
        Birds.RemoveAt(TempVal);

        if (randomX == 0)
        {
            RandPosX = 35f;
            TempObj.GetComponent<sinusoidal>().Direction = sinusoidal.Side.RightSide;
            TempObj.transform.localScale = new Vector3(-1f,1f,1f);//For rotation of Bird
        }
        else if (randomX == 1)
        {
            RandPosX = -35f;
            TempObj.GetComponent<sinusoidal>().Direction = sinusoidal.Side.LeftSide;
        }


        Vector3 randomPosition = new Vector3(RandPosX, RandPosY, 0);
        TempObj.transform.position = randomPosition;
        TempObj.SetActive(true);


        //Debug.LogError("TWO");
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



