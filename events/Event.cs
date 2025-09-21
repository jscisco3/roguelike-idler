using System;
using Godot;
using roguelikeidler.entities;

namespace roguelikeidler.events
{
    [GlobalClass]
    public partial class Event : Resource
    {
        [Export] public String Message { get; set; }

        [Export] public Reward Reward;
        
        public void Resolve(Entity hero) {}

    }
}
