using UnityEngine;

namespace ProjectCondensed.Managers
{
    public static class InputManager
    {
        public static bool IsMovingForward()
        {
            return Input.GetKey(KeyCode.W);
        }
    }
}
