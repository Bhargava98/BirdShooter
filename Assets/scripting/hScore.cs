using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hScore : MonoBehaviour
    {
public Text highScore;
    public Text score;
    //GameObject birdFeathers;
    void start()
    {
        highScore.text = PlayerPrefs.GetInt("highScore").ToString();
    }
    /*public void HScore()
    /*{
       // int number = Random.Range(1, 7);
        //scoreText = number.ToString;

       // if ( > PlayerPrefs.GetInt("highScore"))
        /*{
            PlayerPrefs.GetInt("highScore");
          //  highScore.text = number.ToString();*/
        } 
