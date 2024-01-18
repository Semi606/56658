using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevelButton : MonoBehaviour
{
    // Метод, який буде викликано при натисканні кнопки перезавантаження
    public void RestartLevel()
    {
        // Отримати ім'я поточного рівня
        string currentSceneName = SceneManager.GetActiveScene().name;

        // Перезавантаження поточного рівня
        SceneManager.LoadScene(currentSceneName);
        Time.timeScale = 1f;
    }
}