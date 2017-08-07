using System.Collections.Generic;
using System.IO;
using utility;
using UnityEngine;

namespace controller
{
    public class PartLoader : MonoBehaviour
    {
        
        public static Dictionary<string, PartConfig> Parts = new Dictionary<string, PartConfig>();
            
        private void Awake()
        {
            string blockPath = Path.Combine(Application.streamingAssetsPath, "Blocks");
            foreach (var directory in Directory.GetDirectories(blockPath))
            {
                var blockConfig = Path.Combine(directory, "block.json");
                if (File.Exists(blockConfig))
                {
                    var config = JsonUtility.FromJson<PartConfig>(File.ReadAllText(blockConfig));
                    config.InitTextures(directory);
                    Parts.Add(config.id, config);
                }
			
            }

        }
    }
    
    public class PartConfig
    {
        public string id;
        public string Name;
        public string BaseImage;
        public Sprite BaseImageSprite;
		
        public string LeftImage;
        public Sprite LeftImageSprite;
        public string RightImage;
        public Sprite RightImageSprite;
        public string TopImage;
        public Sprite TopImageSprite;
        public string BottomImage;
        public Sprite BottomImageSprite;

        public void InitTextures(string directory)
        {
            BaseImageSprite = ResourceCache.Cache.Load(Path.Combine(directory, BaseImage));
            
            LeftImageSprite = ResourceCache.Cache.Load(Path.Combine(directory, LeftImage));
            RightImageSprite = ResourceCache.Cache.Load(Path.Combine(directory, RightImage));
            TopImageSprite = ResourceCache.Cache.Load(Path.Combine(directory, RightImage));
            BottomImageSprite = ResourceCache.Cache.Load(Path.Combine(directory, BottomImage));
        }
    }
}