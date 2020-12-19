using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UdemyProject1.Controllers
{
    public class PCInputManager
    {
        public bool LeftMouseButtonDown  => Input.GetMouseButtonDown(0);
        public bool RightMouseButtonDown => Input.GetMouseButtonDown(1);
    }
}
