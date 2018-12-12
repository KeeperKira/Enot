using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class GrassSC : MonoBehaviour {

	private Mesh mesh;
	private Vector3[] vertices;
    public float force = 6.0f;
    // Use this for initialization

    void Start () 
	{

        mesh = GetComponent<MeshFilter>().sharedMesh;
		vertices = mesh.vertices;
	}
	
	// Update is called once per frame
	void Update () 
	{
        
       // mesh.RecalculateBounds();

    }
    void FixedUpdate()
	{
        vertices[1] = new Vector3(0.5f + Mathf.Sin(0.5f+Time.time) / force, vertices[1].y, vertices[1].z);
        vertices[3] = new Vector3(-0.5f + Mathf.Sin(Time.time) / force, vertices[3].y, vertices[3].z);
        mesh.vertices = vertices;
    }
}
