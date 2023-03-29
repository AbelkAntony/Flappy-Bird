using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{

    public GameObject GameOverUi;

    private void Start()
    {
        GameOverUi.SetActive(false);
    }

    public void GameOver()
    {
        GameOverUi.SetActive(true);
        Time.timeScale = 0;
    }

    public void Replay()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}
