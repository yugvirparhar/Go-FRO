using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class touchinput : MonoBehaviour {
    Ray ray;
    public GameObject model;
    public Typer typer;
    public GameObject canvas;

    void Update() {
      // if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began) {
      if (Input.GetMouseButtonDown(0)) {
            //ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
                 //GameObject canvas = GetComponentInChildren<Canvas>().transform.GameObject;

                canvas.SetActive(true);
                typer.Randomize();
               
            

            Debug.Log("hit it");
               // model.SetActive(false);
        }

    } }
}
