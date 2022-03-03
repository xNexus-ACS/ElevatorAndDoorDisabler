using Exiled.Events.EventArgs;

namespace ElevatorAndDoorDisabler
{
    public class EventHandlers
    {
        public bool IAndE = true;
        public void OnInteractingDoor(InteractingDoorEventArgs ev)
        {
            if (!IAndE)
            {
                ev.IsAllowed = false;
                ev.Player.ShowHint("<i>The door and elevators are disabled!</i>");
            }
        }

        public void OnInteractingElevator(InteractingElevatorEventArgs ev)
        {
            if (!IAndE)
            {
                ev.IsAllowed = false;
                ev.Player.ShowHint("<i>The door and elevators are disabled!</i>");
            }
        }
    }
}