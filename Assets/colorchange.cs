
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class colorchange : MonoBehaviour {

   public void restart()
    {
        SceneManager.LoadScene("myscene");

    }
    public void exitgame()
    {

        Debug.Log("Exit pressed");
        Application.Quit();
    }
   
}
