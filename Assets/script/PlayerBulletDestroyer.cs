using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletDestroyer : MonoBehaviour
{
private void OnTriggerEnter(Collider other) 
{
	Destroy(gameObject);
	if (other.tag=="Enemy")
	{
		Scoremanager.instance.killScore += 1;
		Destroy(other.gameObject);
	}
}
}
