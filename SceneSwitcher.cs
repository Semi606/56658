using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSwitcher : MonoBehaviour
{
    // Назва сцени, яку ви хочете завантажити
    public string sceneToLoad;

    void Start()
    {
        // Знаходимо кнопку в ієрархії об'єктів
        Button button = GetComponent<Button>();

        // Додаємо обробник подій для натискання кнопки
        button.onClick.AddListener(LoadScene);
    }

    // Метод, який буде викликаний при натисканні кнопки
    void LoadScene()
    {
        // Завантажуємо нову сцену
        SceneManager.LoadScene(sceneToLoad);
    }
}
