using UnityEngine;
using System.Collections;

public class TimeStopperTreasure : MonoBehaviour {

	public int value = 10;
	public float toStopTime = 10;
	public GameObject explosionPrefab;

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "Player") {
			if (GameManager.gm!=null)
			{
				// tell the game manager to Collect
				GameManager.gm.Collect (value);
			}
			
			// explode if specified
			if (explosionPrefab != null) {
				Instantiate (explosionPrefab, transform.position, Quaternion.identity);
			}

			GameManager.gm.timeStopped += toStopTime;
			GameManager.gm.timeFlow = true;
			
			// destroy after collection
			Destroy (gameObject);
		}
	}
}
