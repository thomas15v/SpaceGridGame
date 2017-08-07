using controller;
using UnityEngine;

namespace Ship
{
	public class ShipBlock : MonoBehaviour
	{
		public PartConfig PartConfig; 
		public GameObject BaseSprite;
		public GameObject LeftWall;
		public GameObject RightWall;
		public GameObject TopWall;
		public GameObject BottomWall;
		public GameObject Part;

		private void Start()
		{
			SetPartConfig(PartLoader.Parts["base.block.cabin"]);
		}

		public void SetPartConfig(PartConfig partConfig)
		{
			PartConfig = partConfig;
			BaseSprite.GetComponent<SpriteRenderer>().sprite = PartConfig.BaseImageSprite;
			LeftWall.GetComponent<SpriteRenderer>().sprite = PartConfig.LeftImageSprite;
			RightWall.GetComponent<SpriteRenderer>().sprite = PartConfig.RightImageSprite;
			BottomWall.GetComponent<SpriteRenderer>().sprite = PartConfig.BottomImageSprite;
			TopWall.GetComponent<SpriteRenderer>().sprite = PartConfig.TopImageSprite;			
		}
	}
}
