using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetBomb : MonoBehaviour
{
    //public GameObject bird;
    GameManager gameManager;

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
            gameManager.decrementTime();
        if (gameManager.ispaused == false)
            Destroy(gameObject);

    }
}
