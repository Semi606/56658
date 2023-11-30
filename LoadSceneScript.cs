using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneScript : MonoBehaviour
{
    // Задаємо ім'я сцени для завантаження через інспектор Unity
    public string sceneToLoad;

    // Функція, яку викликає подія (наприклад, кнопка чи інше подійне спрацювання)
    public void LoadScene()
    {
        // Перевірка, чи ім'я сцени не є порожнім перед завантаженням
        if (!string.IsNullOrEmpty(sceneToLoad))
        {
            // Завантаження сцени за ім'ям
            SceneManager.LoadScene(sceneToLoad);
        }
        else
        {
            // Вивід помилки у випадку, якщо ім'я сцени не вказано
            Debug.LogError("Не вказано ім'я сцени для завантаження!");
        }
    }
}
/* Виклик функції завантаження сцени
GetComponent<LoadSceneScript>().LoadScene();*/