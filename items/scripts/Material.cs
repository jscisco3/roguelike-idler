using Godot;

namespace roguelikeidler.items.scripts
{
    [GlobalClass]
    public partial class Material : Resource 
    {
        [Export] public MaterialType MaterialType { get; set; }
        [Export] public float ValueMultiplier { get; set; } = 1.0f;

        public Material()
        {
        }
    }

    // Set each value explicitly to support adding new values in the middle.
    // By setting the values like this, we can add 99 materials in between easily.
    public enum MaterialType
    {
        Dummy = 0,
        Iron = 100,
        Steel = 200,
    }
}