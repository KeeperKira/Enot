using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class FinishSC : MonoBehaviour {

	public int level = 0;
	public int Openlevel = 0;
	public TakeBonusSC tbs;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.tag == "Player")
		{
			PlayerPrefs.SetInt("Level"+level,1);
			PlayerPrefs.SetInt("Level"+Openlevel,0);
		
			PlayerPrefs.SetInt("ScoreLevel"+level,tbs.score);

            SceneManager.LoadScene("SelectLevel");
		}
	}
}
