using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
  public static GameControl instance;
  public GameObject gameOverText;
  public bool gameOver = false;
public static int score = 0;

void Awake() 
{
    if (instance == null)
        {
            instance = this;
        }
    else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

void Update()
{
    if (gameOver == true && Input.GetButtonDown("Jump"))
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
public void GameOver()
    {
        gameOverText.SetActive (true);
        gameOver = true;
    }
}
