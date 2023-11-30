using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Controller : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    private Rigidbody2D rb;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Отримуємо вхідні дані від гравця
        float horizontalInput = Input.GetAxis("Horizontal"); // Для руху вліво/вправо
        float verticalInput = Input.GetAxis("Vertical");     // Для руху вгору/вниз

        // Рух персонажа
        Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput) * moveSpeed * Time.deltaTime; //вправо і вліво
        transform.Translate(movement);
        if(Input.GetAxis("Horizontal")>0){
            animator.SetBool("Right", true);
        }else if(Input.GetAxis("Horizontal")<0){
            animator.SetBool("Left", true);
        }else{
            animator.SetBool("Left", false);
            animator.SetBool("Right", false);
        }

        Vector3 newPosition = transform.position + new Vector3(0f, verticalInput, 0f) * moveSpeed * Time.deltaTime; //вгору і вниз
        transform.position = newPosition;
        if(Input.GetAxis("Vertical")>0){
            animator.SetBool("Up", true);
        }else if(Input.GetAxis("Vertical")<0){
            animator.SetBool("Down", true);
        }else{
            animator.SetBool("Up", false);
            animator.SetBool("Down", false);
        }
        
    }
}
