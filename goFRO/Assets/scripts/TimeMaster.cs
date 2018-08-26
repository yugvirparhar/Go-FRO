using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TimeMaster : MonoBehaviour {

	DateTime currentDate;
	DateTime oldDate;

	public string saveLocation;
	public static TimeMaster instance;


	void Awake()
	{
		instance = this;
		saveLocation = "lastSavedDate1";
	}

	public float CheckDate()
	{
		currentDate = System.DateTime.Now;
		string tempString = PlayerPrefs.GetString(saveLocation, "1");
		long tempLong = Convert.ToInt64(tempString);
		DateTime oldDate = DateTime.FromBinary(tempLong);

		TimeSpan difference = currentDate.Subtract(oldDate);
		return (float)difference.TotalSeconds;
	}

	public void SaveDate()
	{
		PlayerPrefs.SetString(saveLocation, System.DateTime.Now.ToBinary().ToString());

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
