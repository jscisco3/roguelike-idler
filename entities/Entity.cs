using System;
using Godot;

namespace roguelikeidler.entities
{
    [GlobalClass]
    public partial class Entity : Resource
    {
        [Export] public String Name { get; set; }
        [Export] public EntityStats Stats { get; set; }

        public Entity()
        {
        }
    }
}