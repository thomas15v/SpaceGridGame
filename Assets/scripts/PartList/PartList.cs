using System.Collections;
using controller;
using UnityEngine;

namespace PartList
{
    public class PartList: MonoBehaviour
    {
        public GameObject template;

        private void Start()
        {
            foreach (var part in PartLoader.Parts.Values)
            {
                var item = Instantiate(template);
                item.GetComponent<PartListItem>().SetText(part.Name);
                item.GetComponent<PartListItem>().SetImage(part.BaseImageSprite);
                item.SetActive(true);
                item.transform.SetParent(transform);
            }	
        }
    }
}