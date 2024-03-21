using UnityEngine;
using System.Collections;

namespace Cainos.PixelArtTopDown_Basic
{
    public class TopDownCharacterController : MonoBehaviour
    {
        public float speed;
        public Animator animator;

        private Rigidbody2D rb;
        private Vector2 moveDirection = Vector2.zero;
        private Vector2 previousMoveDirection = Vector2.zero;

    

        private void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            animator = GetComponent<Animator>();
            animator.Play("Anim");
            StartCoroutine(DelayedDisableBoolean());
        }

        private void Update()
        {
            moveDirection.x = Input.GetAxisRaw("Horizontal");
            moveDirection.y = Input.GetAxisRaw("Vertical");

            if (moveDirection != Vector2.zero)
            {
                moveDirection.Normalize();
                previousMoveDirection = moveDirection;
            }

            if (moveDirection != Vector2.zero)
            {
                animator.SetFloat("Horizontal", moveDirection.x);
                animator.SetFloat("Vertical", moveDirection.y);
                animator.SetFloat("Speed", moveDirection.sqrMagnitude);
            }

        }



        private void FixedUpdate()
        {
            rb.velocity = Vector2.zero;

            if (moveDirection != Vector2.zero)
            {
                rb.MovePosition(rb.position + moveDirection * speed * Time.fixedDeltaTime);
            }
            else
            {
                animator.SetFloat("Horizontal", previousMoveDirection.x);
                animator.SetFloat("Vertical", previousMoveDirection.y);
                animator.SetFloat("Speed", 0f);
            }
        }

        IEnumerator DelayedDisableBoolean()
        {
            // Esperar un corto tiempo
            yield return new WaitForSeconds(0.1f); // Puedes ajustar el tiempo según lo necesites
            
            // Desactivar el booleano después de un breve retraso
            animator.SetBool("isTransform", false);
        }

    }
}
