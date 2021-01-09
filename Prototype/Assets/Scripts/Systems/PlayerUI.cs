using ProjectCondensed.Enums;
using UnityEngine;
using UnityEngine.UI;

namespace ProjectCondensed.Systems
{
    public class PlayerUI : MonoBehaviour
    {

        #region Singleton

        private static PlayerUI Instance;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
        }

        public static PlayerUI GetInstance()
        {
            return Instance;
        }


        #endregion

        [SerializeField] private CrosshairMode crosshairMode;

        [SerializeField] private Sprite normalCrosshair, grabCrosshair, shootingCrosshair;

        [SerializeField] private Image crosshairImg;

        private void Update()
        {

        }

        public void ChangeCrosshair(CrosshairMode _mode)
        {
            crosshairMode = _mode;
            UpdateCrosshair();
        }

        private void UpdateCrosshair()
        {
            switch (crosshairMode)
            {
                case CrosshairMode.Normal:
                    crosshairImg.sprite = normalCrosshair;
                    crosshairImg.color = new Color(Color.black.r, Color.black.g, Color.black.b, 0.35f);
                    crosshairImg.transform.localScale = new Vector3(.125f, .125f, .1f);
                    break;
                case CrosshairMode.Grab:
                    crosshairImg.sprite = grabCrosshair;
                    crosshairImg.color = new Color(Color.white.r, Color.white.g, Color.white.b, 0.35f);
                    crosshairImg.transform.localScale = new Vector3(.185f, .185f, .1f);
                    break;
                case CrosshairMode.Shooting:
                    crosshairImg.sprite = shootingCrosshair;
                    crosshairImg.color = new Color(Color.black.r, Color.black.g, Color.black.b, 1f);
                    crosshairImg.transform.localScale = new Vector3(.125f, .125f, .1f);
                    break;
                case CrosshairMode.Break:
                    crosshairImg.sprite = grabCrosshair;
                    crosshairImg.color = new Color(Color.white.r, Color.white.g, Color.white.b, 0.35f);
                    crosshairImg.transform.localScale = new Vector3(.185f, .185f, .1f);
                    break;
            }
        }
    }
}
