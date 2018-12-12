using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class HealtSC : MonoBehaviour {
	
	public int health;
	public float blocked;
	public MovePlayerSC	MoveSC;
	public Image[] Heart;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void FixedUpdate()
	{
		if(blocked > 0.0f)
			blocked -= Time.deltaTime;
		
		HeartUpdate();
		GameOver();
	}
	
	void OnCollisionEnter2D(Collision2D coll) 
	{
        if (coll.gameObject.tag == "Thorns")
		{
			if (blocked <=0) 
			{
				blocked = 0.3f;
				health -=1;
				MoveSC.Block(blocked);
				MoveSC.PainJump();
			}
		}
    }
	
	void OnTriggerEnter2D(Collider2D coll) 
	{
        if (coll.gameObject.tag == "Enemy")
		{
			if (blocked <=0) 
			{
				blocked = 0.3f;
				health -=1;
				MoveSC.Block(blocked);
				MoveSC.PainJump();
			}
		}
    }
	
	void HeartUpdate()
	{
		for(int i =0;i<3;i++)
		{
			if(health >i)
				Heart[i].color = new Color(1, 1, 1, 1);
			else
				Heart[i].color = new Color(0.5f, 1, 1, 1);
		}

	}
	void GameOver()
	{
		if(health <= 0)
		{
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
	}
}
