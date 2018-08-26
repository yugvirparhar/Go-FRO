using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class TrackManager : MonoBehaviour {

    public ImageTargetBehaviour target1;
    public ImageTargetBehaviour target2;

    public GameObject object1;
    public GameObject object2;

    public Animator anim;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (target1.CurrentStatus == TrackableBehaviour.Status.TRACKED && target2.CurrentStatus == TrackableBehaviour.Status.TRACKED)
        {
            anim.SetTrigger("Wave");

        }
    }
}
