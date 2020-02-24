using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public GameObject GameOverPanel;
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(RestartGame);
    }


    public void RestartGame()
    {
        Time.timeScale = 1;
        GameOverPanel.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
