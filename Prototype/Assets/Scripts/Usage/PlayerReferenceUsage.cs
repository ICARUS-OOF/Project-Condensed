using ProjectCondensed.Data;
using UnityEngine;

namespace ProjectCondensed.Usage
{
    public class PlayerReferenceUsage : MonoBehaviour
    {
        protected PlayerReference playerRefInstance;

        protected void FindInstance()
        {
            playerRefInstance = PlayerReference.Instance;
        }
    }
}
