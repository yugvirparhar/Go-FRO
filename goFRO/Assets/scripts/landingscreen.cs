using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class landingscreen : MonoBehaviour {
    public CanvasGroup uielement;
    public GameObject landing;
    public void Start()
    {
        StartCoroutine(FadeCanvasGroup(uielement, uielement.alpha, 0));
    }

    public IEnumerator FadeCanvasGroup(CanvasGroup cg, float start, float end, float lerpTime = 3f)
    {
        float timestartedlerping = Time.time;
        float timeSinceStarted = Time.time - timestartedlerping;
        float percentageComplete = timeSinceStarted / lerpTime;
        while(true)
        {
            timeSinceStarted = Time.time - timestartedlerping;
            percentageComplete = timeSinceStarted / lerpTime;

            float currentvalue = Mathf.Lerp(start, end, percentageComplete);
            cg.alpha = currentvalue;

            if (percentageComplete>=1)
            {

                landing.SetActive(false);
                break;
            }

            yield return new WaitForEndOfFrame(); 
           
        }
    }
}
