using ProjectCondensed.Managers;
using System;
namespace ProjectCondensed.Attributes
{
    public class GameManagerUsageAttribute : Attribute
    {
        protected GameManager gmInstance;
        protected void FindInstance()
        {
            gmInstance = GameManager.GetInstance();
        }
    }
}
