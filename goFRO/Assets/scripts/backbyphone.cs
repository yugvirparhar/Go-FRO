using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class backbyphone : MonoBehaviour
{
    public GameObject menupanel;
    public GameObject streakpanel;

    private void Update()
    {

        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                if (SceneManager.GetActiveScene().name == "SecondProto")
                {
                    if (menupanel.activeSelf )
                    { 
                       menupanel.SetActive(false);
                    }
                    else if (streakpanel.activeSelf)
                    {
                        menupanel.SetActive(true);
                        streakpanel.SetActive(false);
                    }

                    else
                    {
                        Application.Quit();
                    }
                }
                

                


            }
        }
    }
}
