using UnityEngine;

namespace ProjectCondensed.Systems
{
    public class PlayerFeedback : MonoBehaviour
    {
        [SerializeField] private ParticleSystem landingParticles;

        public void Land(float airDuration)
        {
            if (airDuration >= 4f)
            {
                landingParticles.Play();
            }
        }
    }
}
