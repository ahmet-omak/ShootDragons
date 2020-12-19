using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UdemyProject1.Controllers
{
    public class PlayerEventManager:MonoBehaviour
    {
        [SerializeField] float jumpForce=350f;
        [SerializeField] FireballManager FireBall;
        [SerializeField] Transform FireBallPosition;
        [SerializeField] GameObject FireBalls;
        [SerializeField] float ShootWaitTime=1f;
        private float passedTime;

        private void Update()
        {
            CalculatePassedTime();
        }

        public void OnJump(Rigidbody2D rgb)
        {
            rgb.velocity = Vector2.zero;
            rgb.AddForce(Vector2.up * jumpForce);
        }

        private void CalculatePassedTime()
        {
            passedTime += Time.deltaTime;
        }

        public void OnShoot()
        {
            if (passedTime>ShootWaitTime)
            {
                var fireball = Instantiate(FireBall, FireBallPosition.position, FireBall.transform.rotation);
                fireball.transform.parent = FireBalls.transform;
                passedTime = 0f;
            }
        }
    }
}
