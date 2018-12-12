using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//////////////////подвижные платформы. для работы нужны два дочерних обекта между которыми будет ездить платформа (StartPoint, FinishPoint)

public class MovePlatformCS : MonoBehaviour {
	
	public float speed = 1;
	
	private Vector3 startPoint,finishPoint;	
	private Transform startP,finishP;	
	Rigidbody2D rb;
	bool point = false;

	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody2D>();
		
		startP = transform.Find("StartPoint");
		finishP = transform.Find("FinishPoint");
		
		startPoint = startP.position;
		finishPoint = finishP.position;
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		float dist;
		Vector3 move;
		if(point)
		{
			dist = Vector3.Distance(transform.position,finishPoint);
			move = (finishPoint - transform.position)/dist;
			
			if(dist < speed/10)
				point = false;
		}			
		else
		{
			dist = Vector3.Distance(transform.position,startPoint);
			move = (startPoint - transform.position)/dist;
			
			if(dist < speed/10)
				point = true;
		}
			rb.velocity = move*speed;

		startP.position =  startPoint ;
		finishP.position =  finishPoint ;
	}
}
//Debug.Log(" AssetBundle not found");