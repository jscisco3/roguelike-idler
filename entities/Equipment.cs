using Godot;
using roguelikeidler.items.scripts;

namespace roguelikeidler.entities;

[GlobalClass]
public partial class Equipment : Resource
{
    [Export] public Item Weapon;

    public Equipment()
    {
    }
}