using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour
{
    //public GameObject bird;
    GameManager gameManager;
    public GameObject birdFeathers;

    Timer timer;

    void Start()
    {
        timer = GetComponent<Timer>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }


    // Update is called once per frame
    void Update()
    {
        
        //Destroy(gameObject, 8f);
        
    }
    public void OnMouseDown()
    {
        if (gameManager.ispaused == false)
            gameManager.incrementTime();
       if(gameManager.ispaused==false)
        Destroy(gameObject);
        gameManager.IncrementScore();
        

    }
}
