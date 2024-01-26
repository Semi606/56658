using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform target; // Посилання на об'єкт персонажа, за яким слідкує камера
    public float distance = 5.0f; // Відстань від камери до персонажа
    public float height = 3.0f; // Висота камери над персонажем
    public float smoothSpeed = 5.0f; // Скорость згладжування руху камери

    void LateUpdate()
    {
        if (target == null)
        {
            Debug.LogWarning("Не вказано ціль для слідкування камери.");
            return;
        }

        // Обчислення нової позиції камери
        Vector3 desiredPosition = target.position + Vector3.up * height - target.forward * distance;

        // Згладжування руху камери
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothedPosition;

        // Направлення камери на персонажа
        transform.LookAt(target);
    }
}
