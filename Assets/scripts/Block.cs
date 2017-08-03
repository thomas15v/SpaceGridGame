using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Block : MonoBehaviour
{

	public BlockConfig config;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

[Serializable]
public class BlockConfig
{
	public Image baseImage;
	
	public Image leftOpenImage;
	public Image rightOpenImage;
	public Image topOpenImage;
	public Image bottomOpenImage;
	
	public Image leftClosedImage;
	public Image rightClosedImage;
	public Image topClosedImage;
	public Image bottomClosedImage;
	
}
