using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelStart : MonoBehaviour
{
    public void StartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void StartMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void StartMenu_2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
    public void StartMenu_3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }
    public void RestarLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void StartLevel_2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        SceneManager.UnloadSceneAsync("Nivel1");

    }
    public void StartLevel_3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
        SceneManager.UnloadSceneAsync("Nivel1");
        SceneManager.UnloadSceneAsync("Nivel2");
    }
}
