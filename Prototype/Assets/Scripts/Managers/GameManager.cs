using UnityEngine;

namespace ProjectCondensed.Managers
{
    public class GameManager : MonoBehaviour
    {
        #region Singleton
        private static GameManager Instance;
        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
        }
        public static GameManager GetInstance()
        {
            return Instance; 
        }
        #endregion
    }
}
