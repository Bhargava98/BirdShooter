using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    public float timeLeft;
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        text.text = "" + Mathf.Round(timeLeft);

        if(timeLeft<=0)
        {
            timeLeft = 0;
            SceneManager.LoadScene("Gameover");
        }
    }

    public void incrementTime()
    {
        timeLeft += 1;
    }
}
