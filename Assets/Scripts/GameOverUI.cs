using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverUI : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gameOverMenu;

    private void Start()
    {
     //   Cursor.visible = false;
     //   Cursor.lockState = CursorLockMode.Locked;
     //   Time.timeScale = 1;
    }
    private void OnEnable()
    {
        DinoHealth.OnPlayerDeath += EnableGameOverMenu;
    }

    private void OnDisable()
    {
        DinoHealth.OnPlayerDeath -= EnableGameOverMenu;
    }
    public void EnableGameOverMenu()
    {
        gameOverMenu.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }
}
