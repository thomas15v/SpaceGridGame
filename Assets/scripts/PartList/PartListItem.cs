using UnityEngine;
using UnityEngine.UI;

namespace PartList
{
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
}