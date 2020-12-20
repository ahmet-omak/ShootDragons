using UnityEngine;

namespace UdemyProject1.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        private Rigidbody2D playerRgb;
        private PlayerEventManager playerEvents;
        private PCInputManager inputController;
        private bool isLeftClicked;
        private bool isRightClicked;

        private void Start() {
            playerRgb=GetComponent<Rigidbody2D>();
            playerEvents=FindObjectOfType<PlayerEventManager>();
            inputController=new PCInputManager();
        }

        private void Update() {
            SetInput();
        }
        private void SetInput()
        {
            if (inputController.LeftMouseButtonDown)
            {
                isLeftClicked = true;
                return;
            }
            if (inputController.RightMouseButtonDown)
            {
                isRightClicked = true;
                return;
            }
        }

        private void FixedUpdate() {
            Jump();
            Shoot();
        }
        private void Jump()
        {
            if (isLeftClicked)
            {
                playerEvents.OnJump(playerRgb);
                isLeftClicked = false;
            }
        }

        private void Shoot()
        {
            if (isRightClicked)
            {
                playerEvents.OnShoot();
                isRightClicked = false;
            }
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            RedDragonPoolManager.Instance.ResetPoolObjects();
            GameManager.Instance.LoadMenuScene();
        }
    }
}
