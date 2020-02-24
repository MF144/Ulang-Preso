using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed = 5f;

    private float move;
    private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        move = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector2(move * speed, rb.velocity.y);
	}
}
