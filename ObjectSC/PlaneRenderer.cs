using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class PlaneRenderer : MonoBehaviour {
    public SortingLayer LayerName;
    public  string sortingLayerName;
	public	int sortingOrder;

	// Use this for initialization
	void Start () {
		GetComponent<MeshRenderer>().sortingLayerName = sortingLayerName;
		GetComponent<MeshRenderer>().sortingOrder = sortingOrder;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
