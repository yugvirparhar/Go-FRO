using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliderchange : MonoBehaviour {
    public Slider slider;
    private const float timeMax = 1f;
    public float timefilled;
	// Use this for initialization
	void Start () {
        timefilled = 0f;
	}
	
	// Update is called once per frame
	void Update () {
        slider.value = timefilled / timeMax;

	}
}
