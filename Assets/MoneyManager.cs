using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyManager : MonoBehaviour
{   
    static float currentBalance = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //void UpdateMoneyTick()

    public static void IncreaseMoney(float amount)
    {
        currentBalance += amount;
        UpdateText();
    }

    static void UpdateText()
    {
        TextMeshProUGUI money_text = transform.Find("CurrentMoneyText").GetComponent<TextMeshProUGUI>();
        money_text.text = "$" + currentBalance.ToString();
    }
}
