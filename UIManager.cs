using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject panelMenu;
    [SerializeField] GameObject panelAd;

    void Awake()
    {
        panelMenu.SetActive(false); //hide menu in the start
    }

    public void ShowMenu()
    {
        panelMenu.SetActive(true);
    }

    public void HideMenu()
    {
        panelMenu.SetActive(false);
    }

    public void ShowPanelAd()
    {
        panelAd.SetActive(true);
    }

}
