using Godot;
using Godot.Collections;

namespace roguelikeidler.events.definitions
{
    public partial class EventTable : Resource
    {
        [Export] public Array<EventTableEntry> EventTableData { get; set; }

        public Event RollEvent()
        {
            // TODO Finish this
            return EventTableData[EventTableData.Count - 1].Event;
        }
    }
}