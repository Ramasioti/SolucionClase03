using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio03 : MonoBehaviour
{
    /*---- Ordena el Códgo  ----*/

        public float speed; Z; jumpForce;
        bool isJumping;
        private Rigidbody2D rb2d;
        

        private void Start()
        {
            rb2d = GetComponent<Rigidbody2D>();
        }
        private void Update()
        {
            Movement();
        }

        public void Movement()
        {
           
            float movement = Input.GetAxis("Horizontal") * Speed;
            rb2d.velocity = new Vector2(movement, 0);
            
            
     
            if (Input.GetKeyDown(KeyCode.R))
            {
                Z += Time.deltaTime * 10;
                transform.rotation = Quaternion.Euler(0, 0, Z);

            }
            
            if (Input.GetButton("Jump") && !isJumping)
            {
                
                rb2d.AddForce(Vector2.up * jumpForce); Debug.Log("Estoy saltando Wiiii");
                isJumping = true;
            }
    }

}
