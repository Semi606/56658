using UnityEngine;

public class bonuses : MonoBehaviour
{
    public int points = 10; // Кількість балів, які отримується за збір бонусу

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Перевіряємо, чи це персонаж, який збирає бонус
        {
            GameManager.instance.AddScore(points); // Додаємо бали гравцю
            Destroy(gameObject); // Видаляємо бонус зі сцени
        }
    }
}


/*1. Створіть пустий об'єкт (наприклад, порожній GameObject) в сцені Unity, який буде представляти бонус.

2. Прикріпіть до цього об'єкта скрипт bonuses.

3. Встановіть кількість балів points, які гравець отримує за збір цього бонусу.

4. Надайте цьому об'єкту тег "Player" або відповідний тег, який ви використовуєте для персонажа.

5. У вашому GameManager додайте метод AddScore(int points), який додає бали гравцю.