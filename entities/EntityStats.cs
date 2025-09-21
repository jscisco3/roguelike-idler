using Godot;

namespace roguelikeidler.entities 
{
    
    [GlobalClass]
    public partial class EntityStats : Resource
    {
        [Export] public int MaxHealth { get; set; }
        [Export] public int Power { get; set; }
        [Export] public int Defense { get; set; }

        public EntityStats()
        {
        }
    }
}
