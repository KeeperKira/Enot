using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maxVelocitySC : MonoBehaviour {
	private Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if(rb.velocity.y < -30)
			rb.velocity = new Vector2 (rb.velocity.x,-30);
		if(rb.velocity.y > 30)
			rb.velocity = new Vector2 (rb.velocity.x,30);
	}
}
