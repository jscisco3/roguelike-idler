using System;
using System.Linq;
using Godot;
using Godot.Collections;

namespace roguelikeidler.events.definitions
{
    public partial class EventTable : Resource
    {
        [Export] public Array<EventTableEntry> EventTableData { get; set; }

        // TODO: Share this
        private Random _random = new Random();

        public Event RollEvent()
        {
            if (EventTableData.Count == 0)
            {
                GD.PrintErr("No events defined");
                return null;
            }

            var roll = _random.Next(0, MaxWeight()); // 0..9
            GD.Print($"Rolled {roll}");
            var counter = 0;
            // var index = 0;
            foreach (var entry in EventTableData)
            {
                counter += entry.Weight;
                if (counter >= roll)
                {
                    return entry.Event;
                }
            }
            

            GD.PrintErr($"No event found after rolling {roll}");
            return null;
        }

        private int MaxWeight()
        {
            return EventTableData.Sum(entry => entry.Weight);
        }
    }
}