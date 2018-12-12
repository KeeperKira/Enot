using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeLiveSC : MonoBehaviour {
    private bool live = false;
    public float timeLive =2;
    private float timer = 0.0f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (!live)
        {
            live = true;
            timer = Time.time;
        }

        if (live)
        {
            if (timeLive < Time.time - timer)
            {
                live = false;
                transform.gameObject.SetActive(false);              
            }               
        }
    }
}
