using ProjectCondensed.Data;
using ProjectCondensed.Interfaces;
using UnityEngine;

namespace ProjectCondensed.Systems
{
    public class PlayerFeedback : MonoBehaviour, ISingleDataUsage<PlayerReference>
    {
        [SerializeField] private Transform landingPoint;
        [SerializeField] private GameObject landingParticles;

        [SerializeField] private AudioSource footstepAudio;

        private float footstepFadeTime = 4f;

        public PlayerReference UsageField { get; set; }

        private void Start()
        {
            UsageField = PlayerReference.GetInstance();
        }

        public void Footsteps()
        {
            footstepAudio.volume = Mathf.Lerp(footstepAudio.volume, .7f, Time.fixedDeltaTime * footstepFadeTime);
        }

        public void AirAudio()
        {
            footstepAudio.volume = Mathf.Lerp(footstepAudio.volume, 0f, Time.fixedDeltaTime * footstepFadeTime);
        }

        public void Land(float airDuration)
        {
            if (airDuration >= 4.6f)
            {
                UsageField.camAnimator.SetTrigger("Land");
                GameObject _particleInstance = Instantiate(landingParticles, landingPoint.position, landingPoint.rotation);
                Destroy(_particleInstance, 1.4f);
            }
        }
    }
}
