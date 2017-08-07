using controller;
using UnityEngine;

namespace utility
{
	public class initBlock : MonoBehaviour
	{
		void Start ()
		{
			GetComponent<SpriteRenderer>().sprite = PartLoader.Parts["base.block.cabin"].BaseImageSprite;
		}
	}
}
