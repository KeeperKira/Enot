using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnSC : Enemy {
	
	public Transform EnemyPrefab;
	public float DelayTime = 6;
	public float DeltaRand = 2;
	public  float Radius =10;
	private bool Spawn = false;
	private float Timer;

	// Use this for initialization
	void Start () 
	{
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Spawn)
		{
			if(Timer <0 )
			{
				SpawnEnemy();
				delaySpawn();
			}
			Timer-=Time.deltaTime;
		}
	}
	
	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.tag == "Player")
		{
			startSpawn();
		}
	}
	void OnTriggerExit2D(Collider2D col)
	{
		if(col.gameObject.tag == "Player")
		{
			stopSpawn();
		}
	}
	void startSpawn()
	{
		Spawn = true ;
	}
	void SpawnEnemy()
	{
		Vector2 SpawnPoint;
      //  SpawnPoint.x = 1f;
      //  SpawnPoint.y = 0f;

        SpawnPoint = Random.insideUnitCircle;
        SpawnPoint.y = Mathf.Abs(SpawnPoint.y);
        SpawnPoint *= Radius/(Vector2.Distance(Vector2.zero,SpawnPoint));
		SpawnPoint += (Vector2)Plane.position;

		 Instantiate(EnemyPrefab,SpawnPoint,Quaternion.identity); 

	}
	void delaySpawn()
	{
		Timer = DelayTime+Random.Range(0f,DeltaRand);
	}
	
	void stopSpawn()
	{
		Spawn = false ;
	}
}
