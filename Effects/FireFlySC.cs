using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireFlySC : MonoBehaviour {

    private Vector3 Move,StartPos;
    public Vector2 Speed = new Vector2(1, 1);
    public Vector2 Amplitude = new Vector2(1, 1);
    float time;

	// Use this for initialization
	void Start ()
    {
        StartPos = transform.position;
        Move.z = 0;
        Move.x = 0;
        Move.y = 0;
        time = 0;

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void FixedUpdate()
    {
        time += 0.01f; 
        Move.x = Mathf.Sin(time * Speed.x);
        Move.y = Mathf.Sin(time * Speed.y);
        Move *= Amplitude;

        transform.position = StartPos + Move;
    }
}
