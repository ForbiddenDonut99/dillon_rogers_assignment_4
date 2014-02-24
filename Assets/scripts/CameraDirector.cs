using UnityEngine;
using System.Collections;

public class CameraDirector : MonoBehaviour {

	public Camera Camera1, Camera2, Camera3, Camera4, Camera5, Camera6, Camera7;
	public int cameraSelector;

	// Use this for initialization
	void Start () {
		Camera4.enabled = false;
		Camera2.enabled = false;
		Camera3.enabled = false;
		Camera5.enabled = false;
		Camera6.enabled = false;
		Camera7.enabled = false;
		Camera1.enabled = true;
	}

	void Update () {
	
		if (cameraSelector == 2) {
				Camera1.enabled = false;
				Camera2.enabled = true;
				}
		if (cameraSelector == 3) {
				Camera1.enabled = false;
				Camera2.enabled = false;
				Camera3.enabled = true;
				}
		if (cameraSelector == 4) {
				Camera1.enabled = false;
				Camera2.enabled = false;
				Camera3.enabled = false;
				Camera4.enabled = true;
				}
		if (cameraSelector == 5) {
				Camera1.enabled = false;
				Camera2.enabled = false;
				Camera3.enabled = false;
				Camera4.enabled = false;
				Camera5.enabled = true;
		}
		if (cameraSelector == 6) {
				Camera1.enabled = false;
				Camera2.enabled = false;
				Camera3.enabled = false;
				Camera4.enabled = false;
				Camera5.enabled = false;
				Camera6.enabled = true;
		}
		if (cameraSelector == 7) {
				Camera1.enabled = false;
				Camera2.enabled = false;
				Camera3.enabled = false;
				Camera4.enabled = false;
				Camera5.enabled = false;
				Camera6.enabled = false;
				Camera7.enabled = true;
		}
	}
	

	// Update is called once per frame
}
