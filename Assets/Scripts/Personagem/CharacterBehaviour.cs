using UnityEngine;

namespace Character
{
    [DisallowMultipleComponent]
    [RequireComponent(typeof(Rigidbody2D))]
    [RequireComponent(typeof(Animator))]
    public class CharacterBehaviour : MonoBehaviour
    {
        [SerializeField]
        private float xVelocity;

        private new Rigidbody2D rigidbody2D;
        private SpriteRenderer spriteRenderer;
        private Vector2 velocidade = Vector2.zero;
        private Animator animator;
        private int xAxis = 0;


        #region MONOBEHAVIOUR METHODS
        private void Awake()
        {
            rigidbody2D = GetComponent<Rigidbody2D>();
            spriteRenderer = GetComponent<SpriteRenderer>();
            animator = GetComponent<Animator>();
        }

        public void MoveX(int v)
        {
            xAxis = v;

            if (xAxis != 0)
                if (xAxis == -1)
                    spriteRenderer.flipX = true;
                else if (xAxis == 1)
                    spriteRenderer.flipX = false;

            animator.SetBool("walking", true);
        }

        public void Stop()
        {
            xAxis = 0;
            velocidade.x = 0;
            animator.SetBool("walking", false);
        }

        private void FixedUpdate()
        {
            velocidade.x = xAxis * xVelocity * Time.deltaTime;
            rigidbody2D.velocity = velocidade;
        }
        #endregion

    }

}