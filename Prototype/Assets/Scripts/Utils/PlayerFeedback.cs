using ProjectCondensed.Usage;
using UnityEngine;

namespace ProjectCondensed.Systems
{
    public class PlayerFeedback : PlayerReferenceUsage
    {
        [SerializeField] private Transform landingPoint;
        [SerializeField] private GameObject landingParticles;

        private void Start()
        {
            FindInstance();
        }

        public void Land(float airDuration)
        {
            if (airDuration >= 4.6f)
            {
                playerRefInstance.camAnimator.SetTrigger("Land");
                GameObject _particleInstance = Instantiate(landingParticles, landingPoint.position, landingPoint.rotation);
                Destroy(_particleInstance, 1.4f);
            }
        }
    }
}
