using ProjectCondensed.Managers;
using System;
namespace ProjectCondensed.Utils
{
    public class GameManagerUsageAttribute : Attribute
    {
        protected GameManager gmInstance;
        protected void FindGMInstance()
        {
            gmInstance = GameManager.GetInstance();
        }
    }
}
