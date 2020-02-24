using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlipperCollide : MonoBehaviour {

    public GameObject gameOverPanel;


    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Ground")
        {
            // Slippers vanish upon contact with the floor
            Destroy(gameObject);
        }

        if (col.gameObject.name == "Player")
        {
            // Game Over
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
        }
    }
}
