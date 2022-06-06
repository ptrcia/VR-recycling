using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Debug.Log("Quit");
            Application.Quit();
        }
        if (Input.GetKey("0"))
        {
        //  SceneManager.LoadScene("0-menu");
        }
        if (Input.GetKey("1"))
        {
            SceneManager.LoadScene("1-nivel");
        }

    }

    public void MenuGame()
    {
     // SceneManager.LoadScene("0-menu");
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("1-nivel");
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
