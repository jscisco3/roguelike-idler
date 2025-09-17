using System;
using Godot;

namespace roguelikeidler.items.scripts
{
    [GlobalClass]
    public partial class Item : Resource
    {
        [Export] public String Name { get; set; }

        [Export] public String Description { get; set; }

        [Export] public float BaseValue { get; set; }
        [Export] public scripts.Material Material { get; set; }
        [Export] public WeaponStats WeaponStats { get; set; }

        public float GetValue()
        {
            return this.BaseValue * Material.ValueMultiplier;
        }

        public Item()
        {
            WeaponStats = null;
        }
    }
}