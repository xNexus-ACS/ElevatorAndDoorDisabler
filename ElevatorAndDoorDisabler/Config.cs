using Exiled.API.Interfaces;

namespace ElevatorAndDoorDisabler
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public string CommandPerm { get; set; } = "elevatoranddoor.disabler";
    }
}