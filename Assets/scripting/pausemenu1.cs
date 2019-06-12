using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausemenu1 : MonoBehaviour
{
    public string MainMenu;
    public GameManager gm;
    public GameObject backButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void pauseGame()
    {
        gm.ispaused = true;
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0f;
           backButton.SetActive(true);
        }
        else if (Time.timeScale == 0)
        {
            gm.ispaused = false;
            Time.timeScale = 1f;
           backButton.SetActive(false);
        }
    }

    public void quit()
    {
        Application.LoadLevel(MainMenu);
    }

}
