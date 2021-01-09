using ProjectCondensed.Data;
using ProjectCondensed.Enums;
using ProjectCondensed.Interfaces;
using ProjectCondensed.Managers;
using UnityEngine;

namespace ProjectCondensed.Systems
{
    public class PlayerInteraction : MonoBehaviour, I2DataUsages<PlayerReference, PlayerUI>
    {
        [SerializeField] private float interactionDist = 6f;

        private Transform camTransform;

        public PlayerReference UsageField1 { get; set; }
        public PlayerUI UsageField2 { get; set; }

        private void Start()
        {
            UsageField1 = PlayerReference.GetInstance();
            UsageField2 = PlayerUI.GetInstance();
            camTransform = UsageField1.camObject.transform;
        }

        private void Update()
        {
            CastInteractionRay();
        }

        private void CastInteractionRay()
        {
            RaycastHit _hitInfo;

            if (Physics.Raycast(camTransform.position, camTransform.forward, out _hitInfo, interactionDist))
            {
                IInteractable interactable = GameManager.GetComponentFromRaycast<IInteractable>(_hitInfo);

                if (interactable != null)
                {
                    UsageField2.ChangeCrosshair(interactable.crosshairMode);
                } else
                {
                    UsageField2.ChangeCrosshair(CrosshairMode.Normal);
                }

                if (Input.GetKeyDown(InputManager.interactKey))
                {
                    if (interactable != null)
                    {
                        interactable.Interact();
                    }
                }
            } else
            {
                UsageField2.ChangeCrosshair(CrosshairMode.Normal);
            }
        }
    }
}
