using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class LevelSC : MonoBehaviour {
	public Button tButton ;
	// Use this for initialization
	void Start () 
	{
		if (PlayerPrefs.HasKey(this.name))
		{
			if(PlayerPrefs.GetInt(this.name) == -1)
				tButton.interactable = false;
			else
				tButton.interactable = true;
			
			if(PlayerPrefs.GetInt(this.name) >= 1)
				transform.Find("Finish").gameObject.SetActive(true);
		}
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
	
	public void LoadLevel()
	{
        SceneManager.LoadScene(this.name);
       // Application.LoadLevel(this.name);
	}
}
