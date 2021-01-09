using ProjectCondensed.Systems;
using UnityEngine;

namespace ProjectCondensed.Data
{
    public class PlayerReference : MonoBehaviour
    {
        #region Singleton

        private static PlayerReference Instance;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
        }

        public static PlayerReference GetInstance()
        {
            return Instance;
        }

        #endregion

        public GameObject playerObject;
        public GameObject camObject;

        public PlayerMovement playerMovement;
        public CameraMovement camMovement;
        public Animator camAnimator;
    }
}
