using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stopwatch : MonoBehaviour {
    float time = 0f;
    // Use this for initialization
    [SerializeField] Text countdownText;

	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        string minutes = Mathf.Floor(time / 60).ToString("00");
        string seconds = (time % 60).ToString("00");
        countdownText.text = minutes + ":" + seconds;
	}
}
