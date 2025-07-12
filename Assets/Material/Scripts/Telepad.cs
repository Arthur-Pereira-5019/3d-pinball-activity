using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Telepad : MonoBehaviour
{

public Vector3 teleportTo;
public GameObject toActivate;
private ConditionalSpawner cs;

    void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "Player") {
			other.gameObject.transform.position = teleportTo;
            if(toActivate != null) {
                cs = toActivate.GetComponent<ConditionalSpawner>();
                cs.isActivated = true;
            }
		}
	}
}