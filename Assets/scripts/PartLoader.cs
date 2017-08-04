using System.IO;
using UnityEngine;

public class PartLoader : MonoBehaviour {
	
	
	public GameObject template;
	
	// Use this for initialization
	public void Start () {
		string blockPath = Path.Combine(Application.streamingAssetsPath, "Blocks");
		foreach (var directory in Directory.GetDirectories(blockPath))
		{
			var blockConfig = Path.Combine(directory, "block.json");
			if (File.Exists(blockConfig))
			{
				var config = JsonUtility.FromJson<PartConfig>(File.ReadAllText(blockConfig));
				config.InitTextures(directory);
				var item = Instantiate(template);
				item.GetComponent<PartListItem>().SetText(config.Name);
				item.GetComponent<PartListItem>().SetImage(config.BaseImageSprite);
				item.SetActive(true);
				item.transform.SetParent(transform);
			}
			
		}
	}
}

public class PartConfig
{
	public string Name;
	public string BaseImage;
	public Sprite BaseImageSprite;
	
	public string LeftOpenImage;
	public string RightOpenImage;
	public string TopOpenImage;
	public string BottomOpenImage;
	
	public string LeftClosedImage;
	public string RightClosedImage;
	public string TopClosedImage;
	public string BottomClosedImage;

	public void InitTextures(string directory)
	{
		BaseImageSprite = ResourceCache.Cache.Load(Path.Combine(directory, BaseImage));
	}
}