using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class panelmanager : MonoBehaviour {
    public GameObject menu;
    public GameObject menuPanel;
    public GameObject streakPanel;


    public void gotoMenuPanelandback()
    {
        if (menuPanel.activeSelf == false)
        {
            menuPanel.SetActive(true);
            
        }
        else if(streakPanel.activeSelf == true)
        {
            streakPanel.SetActive(false);
            menuPanel.SetActive(false);
        }
        else
        {
            menuPanel.SetActive(false);
        }
    }
    public void gotostreakpanel()
    {
        streakPanel.SetActive(true);
    }
	public void openpage()
    {
        Application.OpenURL("http://www.goodknight.in/products/");
    }
}
