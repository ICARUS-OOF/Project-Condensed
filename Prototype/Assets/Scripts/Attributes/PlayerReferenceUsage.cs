using ProjectCondensed.Data;
using System.Collections;
using System.Collections.Generic;
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
