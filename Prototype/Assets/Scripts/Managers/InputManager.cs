using UnityEngine;

namespace ProjectCondensed.Managers
{
    public static class InputManager
    {
        public static KeyCode crouchKey = KeyCode.LeftControl;
        public static KeyCode interactKey = KeyCode.F;

        public static float GetHorizontalAxis()
        {
            return Input.GetAxisRaw("Horizontal");
        }
        
        public static float GetVerticalAxis()
        {
            return Input.GetAxisRaw("Vertical");
        }

        public static bool IsMovingForward()
        {
            return Input.GetKey(KeyCode.W);
        }

        public static bool IsJumping()
        {
            return Input.GetButton("Jump");
        }

        public static bool IsCrouching()
        {
            return Input.GetKey(KeyCode.LeftControl);
        }
    }
}
