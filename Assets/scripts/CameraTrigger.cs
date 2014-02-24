using UnityEngine;
using System.Collections;

public class CameraTrigger : MonoBehaviour {

	void OnTriggerEnter(Collider target) {
						GetComponent<CameraDirector> ().cameraSelector += 1;
						Debug.Log ("Entered.");
				
		}

}
