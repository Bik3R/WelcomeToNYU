using UnityEngine;
using System.Collections;

public class utilities : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0) {
			Touch theTouch = Input.GetTouch(0);
			if(theTouch.phase == TouchPhase.Ended)
			{
				Application.LoadLevel (Application.loadedLevel);
			}
		}

		// For editor use
		if (Input.GetMouseButtonUp (0)) {
			Application.LoadLevel (Application.loadedLevel);
		}
	}
}
