using Exiled.API.Features;
using System;
using PlayerHandler = Exiled.Events.Handlers.Player;

namespace ElevatorAndDoorDisabler
{
    public class MainClass : Plugin<Config>
    {
        public static MainClass singleton;
        public override string Author { get; } = "xNexus-ACS";
        public override string Name { get; } = "ElevatorAndDoorDisabler";
        public override string Prefix { get; } = "elevator_and_door_disabler";
        public override Version Version { get; } = new Version(0, 1, 0);
        public override Version RequiredExiledVersion { get; } = new Version(5, 0, 0);

        public EventHandlers Ex;

        public override void OnEnabled()
        {
            singleton = this;
            Ex = new EventHandlers();

            PlayerHandler.InteractingDoor += Ex.OnInteractingDoor;
            PlayerHandler.InteractingElevator += Ex.OnInteractingElevator;
            
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            PlayerHandler.InteractingDoor -= Ex.OnInteractingDoor;
            PlayerHandler.InteractingElevator -= Ex.OnInteractingElevator;

            Ex = null;
            singleton = null;
            base.OnDisabled();
        }
    }
}