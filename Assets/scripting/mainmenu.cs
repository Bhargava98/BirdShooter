using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class mainmenu : MonoBehaviour
{
    public void PlayGame()
    {
        
        SceneManager.LoadScene("game");

    }
    public void QuitGame()
    {
        Application.Quit();
    }
     public void about()
     {
         SceneManager.LoadScene(2);
     }

    public void credits()
     {
         SceneManager.LoadScene(3);
     }
 }
