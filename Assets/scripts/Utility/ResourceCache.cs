﻿using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace utility
{
    public class ResourceCache
    {
        public static ResourceCache Cache = new ResourceCache();
        private Dictionary<string, Sprite> _sprites = new Dictionary<string, Sprite>();

        public Sprite Load(string path)
        {
            if (_sprites.ContainsKey(path))
            {
                return _sprites[path];
            }
            else
            {
                return _sprites[path] = LoadSprite(path);
            }
        }
    
        private Sprite LoadSprite(string FilePath, float PixelsPerUnit = 100.0f) {
   
            // Load a PNG or JPG image from disk to a Texture2D, assign this texture to a new sprite and return its reference
            Texture2D SpriteTexture = LoadTexture(FilePath);
            Sprite NewSprite = Sprite.Create(SpriteTexture, new Rect(0, 0, SpriteTexture.width, SpriteTexture.height),new Vector2(0,0), PixelsPerUnit);
 
            return NewSprite;
        }
 
        private Texture2D LoadTexture(string FilePath) {
 
            // Load a PNG or JPG file from disk to a Texture2D
            // Returns null if load fails
 
            Texture2D Tex2D;
            byte[] FileData;
 
            if (File.Exists(FilePath)){
                FileData = File.ReadAllBytes(FilePath);
                Tex2D = new Texture2D(2, 2);           // Create new "empty" texture
                if (Tex2D.LoadImage(FileData))           // Load the imagedata into the texture (size is set automatically)
                    return Tex2D;                 // If data = readable -> return texture
            }  
            return null;                     // Return null if load failed
        }
    
    }
}