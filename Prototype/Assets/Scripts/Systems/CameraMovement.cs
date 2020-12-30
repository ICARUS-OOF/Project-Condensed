using UnityEngine;
namespace ProjectCondensed.Systems
{
    public class CameraMovement : MonoBehaviour
    {
        public Transform player;

        public float lerpTime = 300f;

        void Update()
        {
            transform.position = Vector3.Lerp(transform.position, player.transform.position, lerpTime * Time.fixedDeltaTime);
        }
    }
}