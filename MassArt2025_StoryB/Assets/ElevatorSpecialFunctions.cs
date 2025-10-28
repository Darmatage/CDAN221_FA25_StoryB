using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;

public class ElevatorSpecialFunctions : MonoBehaviour
{
	public TMP_Text objectCountText;
	public int objectCount = 0;

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
	{
		DisplayObjectCount();
	}

	// Update is called once per frame
	void DisplayObjectCount()
	{
		if (GameHandler.hair) { objectCount++; }
		if (GameHandler.teeth) { objectCount++; }
		if (GameHandler.note) { objectCount++; }
		if (GameHandler.journal) { objectCount++; }
		if (GameHandler.key) { objectCount++; }
		if (GameHandler.goldLocket) { objectCount++; }

		if (objectCount == 0)
		{
			objectCountText.text = "???";
		}
		else
		{
			objectCountText.text = "" + objectCount;
		}
	}
	
}
