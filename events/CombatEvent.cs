using Godot;
using System;
using roguelikeidler.entities;

namespace roguelikeidler.events
{
    [GlobalClass]
    public partial class CombatEvent : Event
    {
        [Export] public Entity Combatant { get; set; }

        public CombatEvent()
        {
        }

        public void Resolve(Entity hero)
        {
            GD.Print($"{hero.Name} attacks {Combatant.Name}");
        }
    }
}