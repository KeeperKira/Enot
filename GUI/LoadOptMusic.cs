using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadOptMusic : MonoBehaviour {

	public Toggle tog;
	// Use this for initialization
	void Start () 
	{
		if (PlayerPrefs.HasKey("OptMusic"))
			if(PlayerPrefs.GetInt("OptMusic") == 1)
				tog.isOn = true;
			else
				tog.isOn = false;
			
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
