using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        // Отримуємо введення з клавіатури
        float verticalInput = Input.GetAxis("Vertical");

        // Рухаємо персонажа вверх і вниз
        Vector3 movement = new Vector3(0f, verticalInput, 0f) * speed * Time.deltaTime;
        transform.Translate(movement);
    }
}
