using ProjectCondensed.Managers;
using System;
namespace ProjectCondensed.Usage
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
