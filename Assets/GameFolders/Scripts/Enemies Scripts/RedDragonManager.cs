using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UdemyProject1.Controllers
{
    public class RedDragonManager : MonoBehaviour
    {
        [SerializeField] GameObject ExitPoint;
        private Vector3 exitPoint;

        private void Start()
        {
            SetExitPoint();
        }

        private void Update()
        {
            RemoveRedDragon();
        }

        private   void SetExitPoint()
        {
            exitPoint = ExitPoint.transform.position;
        }

        private void RemoveRedDragon()
        {
            if (gameObject.transform.position.x<exitPoint.x)
            {
                RedDragonPoolManager.Instance.SetPoolObject(this);
            }
        }
    }
}