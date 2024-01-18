using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class Inventory : MonoBehaviour
{
    public List<Item> items = new List<Item>();
    public GameObject inventoryPanel;
    public GameObject inventorySlotPrefab;

    void Start()
    {
        // Ініціалізація інвентаря
        for (int i = 0; i < 5; i++)
        {
            AddItem(new Item("Item " + i, "Description of Item " + i));
        }
        
        UpdateUI();
    }

    public void UpdateUI()
    {
        // Оновлення візуального представлення інвентарю
        ClearInventoryUI();
        for (int i = 0; i < items.Count; i++)
        {
            GameObject slot = Instantiate(inventorySlotPrefab, inventoryPanel.transform);
            slot.GetComponentInChildren<Text>().text = items[i].itemName;
        }
    }

    void ClearInventoryUI()
    {
        // Очищення візуального представлення інвентарю
        foreach (Transform child in inventoryPanel.transform)
        {
            Destroy(child.gameObject);
        }
    }

    public void AddItem(Item item)
    {
        // Додавання предмета до інвентаря
        items.Add(item);
        UpdateUI();
    }
}

[System.Serializable]
public class Item
{
    public string itemName;
    public string itemDescription;

    public Item(string name, string description)
    {
        itemName = name;
        itemDescription = description;
    }
}