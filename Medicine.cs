using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medicine : MonoBehaviour
{
    public int MedicineAmount = 10;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Отримуємо посилання на скрипт гравця
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();

            // Перевіряємо, чи скрипт гравця не є порожнім
            if (playerHealth != null)
            {
                // Викликаємо метод лікування гравця
                playerHealth.TakeMedicine(MedicineAmount);
            }

        }
    }
}