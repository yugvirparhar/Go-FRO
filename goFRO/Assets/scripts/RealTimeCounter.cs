using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealTimeCounter : MonoBehaviour {

	public float timer;

	public float streakBreakTimer;


	public Counter streak;
	float timeInSeconds;

	void Start () {
		streak.count = PlayerPrefs.GetInt("Streak", 0);
		streakBreakTimer = 40;
		timer = 30;
		timer -= TimeMaster.instance.CheckDate();
		streakBreakTimer  -= TimeMaster.instance.CheckDate();
	}
		
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		streakBreakTimer -= Time.deltaTime;

		if(streakBreakTimer <= 0)
		{
			streak.count = 0;
			PlayerPrefs.SetInt("Streak", streak.count);
			ResetClock();
		}
	}

	public void IncreaseStreak()
	{
		if(timer <= 0)
		{	
			streak.count++;
			PlayerPrefs.SetInt("Streak", streak.count);
			ResetClock();
		}
		else
		{
			Debug.Log("Button Locked");
		}
	}

	void ResetClock()
	{
		TimeMaster.instance.SaveDate();
		timer = 30;
		streakBreakTimer = 40;
		timer -= TimeMaster.instance.CheckDate();
		streakBreakTimer  -= TimeMaster.instance.CheckDate();

	}
}
