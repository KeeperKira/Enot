using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventStartSC : MonoBehaviour {

    public GameObject ObjectToVision;
    public bool enter = true;
    public bool exit = false;



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {		
	}


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(enter)
        {
            if (collision.gameObject.tag == "Player")
            { 
                ObjectToVision.SetActive(true);

            }
        }       
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (exit)
        {
            if (collision.gameObject.tag == "Player")
            {
                ObjectToVision.SetActive(true);
            }
        }
    }
}
