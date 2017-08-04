using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class PartListItem : MonoBehaviour
{

	public Image image;
	public Text text;

	public void SetText(string t)
	{
		text.text = t;
	}

	public void SetImage(Sprite sprite)
	{
		image.sprite = sprite;
	}
		
	
}