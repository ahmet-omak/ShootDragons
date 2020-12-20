using UnityEngine;

namespace UdemyProject1.Movements
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class RedDragonMovements : MonoBehaviour
    {
        [SerializeField] float RedDragonMoveSpeed = 5f;
        [SerializeField] Directions direction;
        private Vector2 vector2;
        new Rigidbody2D rigidbody2D;

        private void Awake()
        {
            rigidbody2D = GetComponent<Rigidbody2D>();
        }

        private void OnEnable()
        {
            SetVelocity();
            AddForceToVelocity();
        }

        private void SetVelocity()
        {
            if (direction == Directions.Left)
            {
                vector2 = Vector2.left;
                return;
            }
            if (direction == Directions.Right)
            {
                vector2 = Vector2.right;
                return;
            }
        }

        private void AddForceToVelocity()
        {
            rigidbody2D.velocity = vector2* RedDragonMoveSpeed;
        }

        enum Directions
        {
            Left,Right
        };
    }
}