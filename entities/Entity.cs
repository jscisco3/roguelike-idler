using System;
using Godot;

namespace roguelikeidler.entities
{
    [GlobalClass]
    public partial class Entity : Resource
    {
        [Export] public String Name { get; set; }
        [Export] public EntityStats Stats { get; set; }
        
        [Export] public Equipment Equipment { get; set; }

        public Entity()
        {
        }
    }
}