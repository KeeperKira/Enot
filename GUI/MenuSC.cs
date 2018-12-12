using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuSC : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void Quit()
	{
		Application.Quit();
	}
	
	public void NewGame()
	{
		PlayerPrefs.SetInt("Level1",0);
		
		for(int i = 2;i<=10;i++)
			PlayerPrefs.SetInt("Level"+i,-1);

        SceneManager.LoadScene("SelectLevel");
	}	

}
