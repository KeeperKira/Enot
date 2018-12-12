using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalParamSC : MonoBehaviour {

    static public Vector3 startPoint;

    static private GameObject firstInstance = null;

    void Awake()
    {
        if (firstInstance == null)
        {
            DontDestroyOnLoad(this);
            firstInstance = gameObject;
            startPoint = GameObject.Find("StartGamePoint").transform.position;
        }

        else if (gameObject != firstInstance)
            Destroy(gameObject);         // самоуничтожение
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    static public void SetPoint(Vector3 Obj)
    {
        startPoint = Obj;
    }
}
