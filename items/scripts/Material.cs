using Godot;

namespace roguelikeidler.items.scripts
{
    [GlobalClass]
    public partial class Material : Resource 
    {
        [Export] public MaterialType MaterialType { get; set; }
        [Export] public float ValueMultiplier { get; set; }

        public Material()
        {
        }
    }

    public enum MaterialType
    {
        Iron,
        Steel
    }
}