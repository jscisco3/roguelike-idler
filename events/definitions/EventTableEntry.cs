using Godot;
using System;


namespace roguelikeidler.events.definitions
{
 
    public partial class EventTableEntry : Resource
    {
        [Export]
        public Event Event { get; set; }
        
        [Export]
        public int Weight { get; set; }
    }   
}
