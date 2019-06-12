using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalScore : MonoBehaviour
{
    GameManager gameManager;

    int Score;

    public Text scoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GetComponent<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = " " + Score;
    }
}
