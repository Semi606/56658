using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float moveSpeed = 5.0f; // Швидкість руху персонажа

    void Update()
    {
        // Отримуємо вхідні дані від гравця
        float horizontalInput = Input.GetAxis("Horizontal"); // Для руху вліво/вправо
        float verticalInput = Input.GetAxis("Vertical");     // Для руху вгору/вниз

        // Рух персонажа
        Vector3 movement = new Vector3(horizontalInput, verticalInput);
        movement.Normilize();
        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }
}
