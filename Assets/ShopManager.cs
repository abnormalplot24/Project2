using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject shop;
    public static bool shopActive = true;
    public static bool palmUnlocked = false;
    public static bool pineUnlocked = false;
    public static bool firUnlocked = false;
    public static bool oakUnlocked = false;
    public static bool poplarUnlocked = false;
    void Start()
    {
        Button inventoryButton = shop.transform.Find("ShopItems").Find("Items").Find("BuyAcornButton").GetComponent<Button>();
        inventoryButton.onClick.AddListener(OnPressBuyAcorn);

        inventoryButton = shop.transform.Find("ShopItems").Find("Items").Find("CloseShop").GetComponent<Button>();
        inventoryButton.onClick.AddListener(OnPressCloseShop);

        inventoryButton = shop.transform.Find("ShopItems").Find("Items").Find("BuyStreetTreeButton").GetComponent<Button>();
        inventoryButton.onClick.AddListener(OnPressBuyStreetTree);

        inventoryButton = shop.transform.Find("ShopItems").Find("Items").Find("BuyPalmButton").GetComponent<Button>();
        inventoryButton.onClick.AddListener(OnPressBuyPalm);

        inventoryButton = shop.transform.Find("ShopItems").Find("Items").Find("BuyPineButton").GetComponent<Button>();
        inventoryButton.onClick.AddListener(OnPressBuyPine);

        inventoryButton = shop.transform.Find("ShopItems").Find("Items").Find("BuyFirButton").GetComponent<Button>();
        inventoryButton.onClick.AddListener(OnPressBuyFir);

        inventoryButton = shop.transform.Find("ShopItems").Find("Items").Find("BuyOakButton").GetComponent<Button>();
        inventoryButton.onClick.AddListener(OnPressBuyOak);

        inventoryButton = shop.transform.Find("ShopItems").Find("Items").Find("BuyPoplarButton").GetComponent<Button>();
        inventoryButton.onClick.AddListener(OnPressBuyPoplar);
        shopActive = false;
    }

    void OnPressCloseShop()
    {
        shopActive = false;
    }
    void OnPressBuyStreetTree()
    {
        Button inventoryButton = shop.transform.Find("ShopItems").Find("Items").Find("BuyStreetTreeButton").GetComponent<Button>();
        TextMeshProUGUI cost_text = inventoryButton.transform.Find("quantity_text").GetComponent<TextMeshProUGUI>();
        float cost = float.Parse(cost_text.text.Substring(1));
        if (MoneyManager.currentBalance >= cost)
        {
            MoneyManager.DecreaseMoney(cost);
            GameObject invSys = GameObject.Find("InventorySystem");
            Button button = invSys.transform.Find("Viewport").Find("Content").Find("StreetTreeButton").GetComponent<Button>();
            TextMeshProUGUI quantity_text = button.transform.Find("quantity_text").GetComponent<TextMeshProUGUI>();
            quantity_text.text = (float.Parse(quantity_text.text) + 1).ToString();
        }
    }
    void OnPressBuyPine()
    {
        print(pineUnlocked);
        if (pineUnlocked)
        {
            Button inventoryButton = shop.transform.Find("ShopItems").Find("Items").Find("BuyPineButton").GetComponent<Button>();
            TextMeshProUGUI cost_text = inventoryButton.transform.Find("quantity_text").GetComponent<TextMeshProUGUI>();
            float cost = float.Parse(cost_text.text.Substring(1));
            if (MoneyManager.currentBalance >= cost)
            {
                MoneyManager.DecreaseMoney(cost);
                GameObject invSys = GameObject.Find("InventorySystem");
                Button button = invSys.transform.Find("Viewport").Find("Content").Find("PineButton").GetComponent<Button>();
                TextMeshProUGUI quantity_text = button.transform.Find("quantity_text").GetComponent<TextMeshProUGUI>();
                quantity_text.text = (float.Parse(quantity_text.text) + 1).ToString();
            }
        }
        
    }
    void OnPressBuyPalm()
    {
        print(palmUnlocked);
        if (palmUnlocked)
        {
            Button inventoryButton = shop.transform.Find("ShopItems").Find("Items").Find("BuyPalmButton").GetComponent<Button>();
            TextMeshProUGUI cost_text = inventoryButton.transform.Find("quantity_text").GetComponent<TextMeshProUGUI>();
            float cost = float.Parse(cost_text.text.Substring(1));
            if (MoneyManager.currentBalance >= cost)
            {
                MoneyManager.DecreaseMoney(cost);
                GameObject invSys = GameObject.Find("InventorySystem");
                Button button = invSys.transform.Find("Viewport").Find("Content").Find("PalmButton").GetComponent<Button>();
                TextMeshProUGUI quantity_text = button.transform.Find("quantity_text").GetComponent<TextMeshProUGUI>();
                quantity_text.text = (float.Parse(quantity_text.text) + 1).ToString();
            }
        }
            
    }
    void OnPressBuyFir()
    {
        print(firUnlocked);
        if(firUnlocked)
        {
            Button inventoryButton = shop.transform.Find("ShopItems").Find("Items").Find("BuyFirButton").GetComponent<Button>();
            TextMeshProUGUI cost_text = inventoryButton.transform.Find("quantity_text").GetComponent<TextMeshProUGUI>();
            float cost = float.Parse(cost_text.text.Substring(1));
            if (MoneyManager.currentBalance >= cost)
            {
                MoneyManager.DecreaseMoney(cost);
                GameObject invSys = GameObject.Find("InventorySystem");
                Button button = invSys.transform.Find("Viewport").Find("Content").Find("FirButton").GetComponent<Button>();
                TextMeshProUGUI quantity_text = button.transform.Find("quantity_text").GetComponent<TextMeshProUGUI>();
                quantity_text.text = (float.Parse(quantity_text.text) + 1).ToString();
            }
        }
    }
    void OnPressBuyOak()
    {
        print(oakUnlocked);
        if (oakUnlocked)
        {
            Button inventoryButton = shop.transform.Find("ShopItems").Find("Items").Find("BuyOakButton").GetComponent<Button>();
            TextMeshProUGUI cost_text = inventoryButton.transform.Find("quantity_text").GetComponent<TextMeshProUGUI>();
            float cost = float.Parse(cost_text.text.Substring(1));
            if (MoneyManager.currentBalance >= cost)
            {
                MoneyManager.DecreaseMoney(cost);
                GameObject invSys = GameObject.Find("InventorySystem");
                Button button = invSys.transform.Find("Viewport").Find("Content").Find("OakButton").GetComponent<Button>();
                TextMeshProUGUI quantity_text = button.transform.Find("quantity_text").GetComponent<TextMeshProUGUI>();
                quantity_text.text = (float.Parse(quantity_text.text) + 1).ToString();
            }
        }
    }
    void OnPressBuyPoplar()
    {
        print(poplarUnlocked);
        if(poplarUnlocked)
        {
            Button inventoryButton = shop.transform.Find("ShopItems").Find("Items").Find("BuyPoplarButton").GetComponent<Button>();
            TextMeshProUGUI cost_text = inventoryButton.transform.Find("quantity_text").GetComponent<TextMeshProUGUI>();
            float cost = float.Parse(cost_text.text.Substring(1));
            if (MoneyManager.currentBalance >= cost)
            {
                MoneyManager.DecreaseMoney(cost);
                GameObject invSys = GameObject.Find("InventorySystem");
                Button button = invSys.transform.Find("Viewport").Find("Content").Find("PoplarButton").GetComponent<Button>();
                TextMeshProUGUI quantity_text = button.transform.Find("quantity_text").GetComponent<TextMeshProUGUI>();
                quantity_text.text = (float.Parse(quantity_text.text) + 1).ToString();
            }
        }
    }
    void OnPressBuyAcorn()
    {
        Button inventoryButton = shop.transform.Find("ShopItems").Find("Items").Find("BuyAcornButton").GetComponent<Button>();
        TextMeshProUGUI cost_text = inventoryButton.transform.Find("quantity_text").GetComponent<TextMeshProUGUI>();
        float cost = float.Parse(cost_text.text.Substring(1));
        if (MoneyManager.currentBalance >= cost)
        {
            MoneyManager.DecreaseMoney(cost);
            GameObject invSys = GameObject.Find("InventorySystem");
            Button button = invSys.transform.Find("Viewport").Find("Content").Find("AcornButton").GetComponent<Button>();
            TextMeshProUGUI quantity_text = button.transform.Find("quantity_text").GetComponent<TextMeshProUGUI>();
            /*print(quantity_text.text);
            print(float.Parse(quantity_text.text));
            print((float.Parse(quantity_text.text) + 1).ToString());*/
            quantity_text.text = (float.Parse(quantity_text.text) + 1).ToString();
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (shopActive)
        {
            shop.SetActive(true);
        }
        else
        {
            shop.SetActive(false);
        }
    }
}
