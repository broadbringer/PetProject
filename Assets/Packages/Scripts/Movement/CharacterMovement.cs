using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    
    public float speed = 5f; // скорость движения персонажа
    private bool isMoving = false; // персонаж движется или нет
    private Vector3 direction = Vector3.zero; // направление движения персонажа
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update() {
        float horizontal = Input.GetAxisRaw("Horizontal"); // ось горизонтального движения (A/D или ←/→)
        float vertical = Input.GetAxisRaw("Vertical"); // ось вертикального движения (W/S или ↑/↓)
    
        // определение направления движения
        if (vertical > 0f) {
            direction = transform.forward; // направление вперед
        } else if (vertical < 0f) {
            direction = -transform.forward; // направление назад
        } else if (horizontal > 0f) {
            direction = transform.right; // направление вправо
        } else if (horizontal < 0f) {
            direction = -transform.right; // направление влево
        }
    
        // проверка наличия движения
        if (vertical != 0f || horizontal != 0f) {
            isMoving = true;
        } else {
            isMoving = false;
        }
    
        // изменение скорости персонажа в зависимости от наличия бега
        if (Input.GetKey(KeyCode.LeftShift)) {
            speed = 10f; // скорость бега
        } else {
            speed = 5f; // скорость ходьбы
        }
    
        // перемещение персонажа
        if (isMoving) {
            transform.position += direction * speed * Time.deltaTime;
        }
    }
}
