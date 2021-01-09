using ProjectCondensed.Enums;

namespace ProjectCondensed.Interfaces
{
    internal interface ITriggeredInteractable
    {
        bool isTriggered { get; set; }
    }
    public interface IInteractable
    {
        CrosshairMode crosshairMode { get; set; }
        void Interact();
    }
}
