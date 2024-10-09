using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoremanager : MonoBehaviour
{
	public static Scoremanager instance;
	public int killScore;

	void Awake()
	{
		if (instance == null)
			instance = this;
		else
		{
			print("Duplecated ScoreManager, ignoring this one");
			Destroy(gameObject);
		}
	}
	void Start()
	{
		killScore = 0;
	}
}
