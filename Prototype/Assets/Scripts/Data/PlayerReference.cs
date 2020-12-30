using ProjectCondensed.Systems;
using UnityEngine;

namespace ProjectCondensed.Data
{
    public class PlayerReference : MonoBehaviour
    {
        #region Singleton
        public static PlayerReference Instance;
        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
        }
        #endregion
        public PlayerMovement playerMovement;
        public CameraMovement camMovement;
    }
}
