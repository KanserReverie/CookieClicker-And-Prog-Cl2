using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




// Doesn't work!!!
// Cookie upgade fix
public class CookieManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private int cookies = 0;
    [SerializeField] private int cookiesPerClick = 1;
    [SerializeField] private Text cookieText;
    [SerializeField] private int upgradeCost;
    [SerializeField] private Text upgradeText;




    public void Start()
    {
        UpdateCookieText();
        UpdateUpgradeText();
    }

    public void AddCookie()
    {
        cookies += cookiesPerClick;
        UpdateCookieText();
        UpdateUpgradeText();
    }

    public void UpgradeCookiesPerClick()
    {
        UpgradeCost();
        cookiesPerClick++;
    }

    
    private void UpgradeCost()
    {
        if (cookies >= upgradeCost)
        {
            cookies -= upgradeCost;
            upgradeCost = upgradeCost * 2;
        }
        UpdateUpgradeText();
    }

    private void UpdateUpgradeText()
    {
        if (upgradeText != null)
        {
            upgradeText.text = ("Cost for upgrade = " + upgradeCost + " Cookies");
             
        }
        else
        {
            Debug.LogWarning("upgradeText is not set");
        }
    }




    private void UpdateCookieText()
    {
        if (cookieText != null)
        {
            switch (cookies)
            {
                case 0:
                    cookieText.text = "No Cookies";
                    break;
                case 1:
                    cookieText.text = "One Cookie";
                    break;
                default:
                    cookieText.text = cookies + " Cookies";
                    break;
            }
        }
        else
        {
            Debug.LogWarning("cookieText is not set");
        }
    }
}
