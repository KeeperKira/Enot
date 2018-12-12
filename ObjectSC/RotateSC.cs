using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSC : MonoBehaviour {

    public float rotateSpeed = 3f;
    private Rigidbody2D rb;

    void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
		
	}
	
	// Update is called once per frame
	void Update () {
        
    }

     void FixedUpdate()
    {
        rb.MoveRotation(rb.rotation - rotateSpeed);
    }
}
