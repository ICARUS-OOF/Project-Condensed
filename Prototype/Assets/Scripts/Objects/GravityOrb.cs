using ProjectCondensed.Enums;
using ProjectCondensed.Interfaces;
using UnityEngine;

namespace ProjectCondensed.Objects
{
    public class GravityOrb : MonoBehaviour, IInteractable, ITriggeredInteractable
    {
        public bool isTriggered { get; set; }

        [SerializeField] private CrosshairMode _crosshairMode;
        public CrosshairMode crosshairMode
        {
            get { return _crosshairMode; }
            set { crosshairMode = _crosshairMode; }
        }

        public void Interact()
        {
            if (isTriggered)
            { return; }
            isTriggered = true;
        }
    }
}
