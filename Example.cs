using UnityEngine;

public class Example : MonoBehaviour
{
    public Inventory inventory;

    void Start()
    {
        // Створення нового предмета
        Item newItem = new Item("Меч", "Один з найдавніших знарядь бойового мистецтва");

        // Додавання предмета до інвентаря
        inventory.AddItem(newItem);

        // Оновлення інтерфейсу користувача
        inventory.UpdateUI();
    }
}
