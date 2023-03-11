using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRun : MonoBehaviour
{
        public float speed = 5f; // Player's speed
        public Animator animator; // Reference to animator component

        private Vector3 movement; // Movement vector

        void Update()
        {
            // Get horizontal and vertical input values
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            // Normalize input vector
            Vector3 inputVector = new Vector3(horizontal, 0, vertical).normalized;

            // Calculate movement vector
            movement = inputVector * speed * Time.deltaTime;

            // Play running animation if the player is moving
            if (movement.magnitude > 0)
            {
                animator.SetBool("run_forward", true);
            }
            else
            {
                animator.SetBool("run_forward", false);
            }
        }
}

