using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
    
    public void StartGame()
    {
        SceneManager.LoadScene("Main");
    }

    public void QuitGame(){
        Application.Quit();
    }
}
