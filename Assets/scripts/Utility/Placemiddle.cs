using UnityEngine;

namespace utility
{
	public class Placemiddle : MonoBehaviour {

		// Use this for initialization
		void Start () {
			gameObject.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width/2, Screen.height/2, 
				Camera.main.nearClipPlane));
		}
	}
}
