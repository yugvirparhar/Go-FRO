using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class displayStreak : MonoBehaviour {

    public string SaveLocation;
	
	// Update is called once per frame
	void Update () {
        Text streakCount = gameObject.GetComponent<Text>();
        streakCount.text = PlayerPrefs.GetInt("Streak", 0).ToString();
	}
}
