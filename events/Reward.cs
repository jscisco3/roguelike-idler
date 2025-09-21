using System;
using Godot;

namespace roguelikeidler.events
{
    [GlobalClass]
    public partial class Reward: Resource
    {
        [Export]
        public int Gold = 0;
        [Export]
        public int Crystals = 0;
        // public Array<Item> items = [];

        public Reward()
        {
        }

        public Reward(int gold, int crystals)
        {
            Gold = gold;
            Crystals = crystals;
        }

        public Reward(int minGold, int maxGold, int minCrystals, int maxCrystals)
        {
            Gold = new Random().Next(minGold, maxGold);
            Crystals = new Random().Next(minCrystals, maxCrystals);
        }
        
    }
}