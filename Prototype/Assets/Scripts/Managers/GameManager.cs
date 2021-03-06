using ProjectCondensed.Data;
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

        #region Settings

        public static class Settings
        {

        }

        #endregion

        #region Setup

        private void Start()
        {
            GameObject[] gmObjs = GameObject.FindGameObjectsWithTag(GameConstants.Manager);
            if (gmObjs.Length > 1)
            {
                Destroy(this.gameObject);
            } else
            {
                DontDestroyOnLoad(this.gameObject);
            }
        }

        #endregion

        #region Util
        
        public static T GetComponentFromRaycast<T>(RaycastHit _hit)
        {
            return _hit.collider.GetComponent<T>();
        }

        #endregion
    }
}
