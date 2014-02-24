using UnityEngine;
using System.Collections;

public class BasketMover : MonoBehaviour {
	
	public GameObject basketCar;
	public GameObject targetBasketCar1, targetBasketCar2;
	public float speed = 500f;
	public float startTime;
	public float journeyLength;
	public float smoothLength = 1.0f;
	public bool journeyStart = false;
	public float basketRotatorSpeed = 3f;

	void Start() {
		journeyLength = Vector3.Distance (basketCar.transform.position, targetBasketCar1.transform.position);

		}

	void OnTriggerEnter(Collider other) {
		journeyStart = true;
		//GetComponent<CameraDirector> ().cameraSelector = 4;
	}
	

	void Update() {
		if (journeyStart == true) {
			basketCar.transform.position = Vector3.MoveTowards(basketCar.transform.position, targetBasketCar1.transform.position, Time.deltaTime * 3);
				}
		if (basketCar.transform.position == targetBasketCar1.transform.position) {
			basketCar.transform.Rotate (Vector3.left * basketRotatorSpeed);
			Debug.Log("Rotating.");
			}


		}

}
