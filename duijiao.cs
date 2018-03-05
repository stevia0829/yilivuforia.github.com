using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class duijiao : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Vuforia.CameraDevice.Instance.SetFocusMode(Vuforia.CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
	}
	
	// Update is called once per frame
	void Update () {

		#if UNITY_EDITOR  
		if(Input.GetMouseButtonUp(0))  
		#elif UNITY_ANDROID || UNITY_IPHONE  
		if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)  
		#endif  
		{  
			Vuforia.CameraDevice.Instance.SetFocusMode(Vuforia.CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);  
		}  
	}
}
