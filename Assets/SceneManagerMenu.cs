using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerMenu : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("1");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
