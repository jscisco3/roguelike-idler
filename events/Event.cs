using System;
using Godot;

namespace roguelikeidler.events
{
    [GlobalClass]
    public partial class Event : Resource
    {
        [Export] public String Message { get; set; }

        [Export] public Reward Reward;
    }
}
