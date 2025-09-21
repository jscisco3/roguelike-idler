using System;
using Godot;

namespace roguelikeidler.events
{
    [GlobalClass]
    public partial class Event : Resource
    {
        [Export] public String Message { get; set; }

        [Export] public Reward Reward;
        
        // This will need refactoring later
        [Export] public int GoldGainedOrLost { get; set; }
        [Export] public int CrystalsGainedOrLost { get; set; }
        
        // Maybe something here about the entities you encounter.
        // Will need to figure that out.
    }
}
