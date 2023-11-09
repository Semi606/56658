using UnityEngine;
using UnityEngine.SceneManagement;

public class levelload : MonoBehaviour
{
    public string sceneToLoad; // Назва сцени, яку потрібно завантажити

    public void LoadScene()
    {
        SceneManager.LoadScene(sceneToLoad); // Завантажуємо сцену
    }
}
