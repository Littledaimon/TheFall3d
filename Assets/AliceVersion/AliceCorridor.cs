﻿using UnityEngine;
using System.Collections;

public class AliceCorridor : MonoBehaviour {

	//public
	public ArrayList PreviousLayer;
	private GameObject ShapeHolder;
	// Use this for initialization
	void Start () {
		//PreviousLayer = new ArrayList ();
		Mesh mesh = new Mesh();
		Vector3[] vertices = new Vector3[3];
			vertices [0] = new Vector3 (0, 0, 0);
		vertices [1] = new Vector3 (1, 0, 0);
			vertices [2] = new Vector3 (0,0,1);
		mesh.vertices = vertices;
	
		int[] triangles = {0,2,1};
		mesh.triangles = triangles;

		GetComponent<MeshFilter>().mesh = mesh;
		}

	
	// Update is called once per frame

	Vector3[] GenerateOutline(int sections = 4, float height = 0)
	{
		Vector3[] newOutline = new Vector3[4 +(sections-1)*4];
		Debug.Log ("newOutline length is = " + newOutline.Length);

		float sampleOffset = 0;

		for (int i = 0; i < sections; i++)
		{
			newOutline[i] = 			new Vector3(sampleOffset, height ,Random.Range(-0.1f,0.1f) );
			newOutline[i+sections*2] =	new Vector3(sampleOffset, height ,Random.Range(-0.1f,0.1f) );

            newOutline[i+sections] = 	new Vector3(Random.Range(-0.1f,0.1f), height, sampleOffset);
            newOutline[i+sections*3] = 	new Vector3(Random.Range(-0.1f,0.1f), height, sampleOffset);
		}

		return newOutline;
	}

	int[] GenerateTriangles(Vector3[] topLine, Vector3[] BottomLine)
	{
		int[] newTriangles = new int[3*(topLine+BottomLine)];

	}

	/*
	ArrayList GenerateBorder (int sections = 4, float height = 0)
	{
		ArrayList Border = new ArrayList();

		float x = 0;
		float y = 0;

		Border.Add ( new Vector3(x, height, y) );
		// create first wall
		for (int i = 0; i < sections; i++)
		{
			x += Random.Range(0.1, (1.0/sections) );
			Border.Add ( new Vector3(x, height, y) );
		}
		Border.Add ( new Vector3(1, height, 0) );

		return Border;
	}

	void GenerateLayer(float endWidth, float endHeight)
	{
		// create an object for the shape
		ShapeHolder = new GameObject();
		// generate the shape of it
		ArrayList topBorder = PreviousLayer;

		ArrayList bottomBorder = new ArrayList();
		// generate bottom layer from at least 4 points


		// apply shape to object

		// add the self-destruct script
		// save shape
		// release game object
	}*/

}