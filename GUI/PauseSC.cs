using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PauseSC : MonoBehaviour {
	
	public bool isPaused = false;
	public GameObject Menu;
	public GameObject Interface;

	// Use this for initialization
	void Start () {
		isPaused = false;
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			Pause();
		}
		
		if(isPaused)
			Time.timeScale = 0;
		else
			Time.timeScale = 1;
	}
	
	public void Pause()
	{
		isPaused = ! isPaused;
		Menu.SetActive(isPaused);
		Interface.SetActive(!isPaused);
	}
	
	public void Exit()
	{
        SceneManager.LoadScene("MainMenu");
	}
}
