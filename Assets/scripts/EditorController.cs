using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class EditorController : MonoBehaviour {
	
	private string blockPath = Path.Combine(Application.streamingAssetsPath, "Blocks");

	// Use this for initialization
	void Start () {
		foreach (var directory in Directory.GetDirectories(blockPath))
		{
			var blockConfig = Path.Combine(directory, "block.json");
			if (File.Exists(blockConfig))
			{
				
			}
			
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
