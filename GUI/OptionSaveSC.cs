using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionSaveSC : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void SaveSound(Toggle trig)
	{
		if(trig.isOn)
			PlayerPrefs.SetInt("OptSound", 1);
		else
			PlayerPrefs.SetInt("OptSound", 0);
	}
	
	public void SaveMusic(Toggle trig)
	{
		if(trig.isOn)
			PlayerPrefs.SetInt("OptMusic", 1);
		else
			PlayerPrefs.SetInt("OptMusic", 0);
	}

}
