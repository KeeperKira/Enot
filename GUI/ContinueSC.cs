using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class ContinueSC : MonoBehaviour {

	// Use this for initialization
	public Button tButton ;
	void Start () {
		if (PlayerPrefs.HasKey("Level1"))
			tButton.interactable = true;
		else
			tButton.interactable = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void ContinueGame()
	{
        SceneManager.LoadScene("SelectLevel");
    }
}