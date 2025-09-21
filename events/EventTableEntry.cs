using Godot;

namespace roguelikeidler.events
{
 
    [GlobalClass]
    public partial class EventTableEntry : Resource
    {
        [Export]
        public events.Event Event { get; set; }
        
        [Export]
        public int Weight { get; set; }
    }   
}
