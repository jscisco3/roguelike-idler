using Godot;

namespace roguelikeidler.items.scripts
{
    [GlobalClass]
    public partial class WeaponStats : Resource
    {
        [Export] public int Damage { get; set; }

        public WeaponStats()
        {
        }
    }
    
}
