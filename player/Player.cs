using Godot;
using System;

namespace roguelikeidler.player
{
    public partial class Player : Node
    {
        private int _gold;

        public int Gold
        {
            get => _gold;
            set
            {
                _gold = value;
                EmitSignal(SignalName.GoldChanged, Gold);
            }
        }

        private int _crystals;

        public int Crystals
        {
            get => _crystals;
            set
            {
                _crystals = value;
                EmitSignal(SignalName.CrystalsChanged, Crystals);
            }
        }

        public void GainGold(int amount)
        {
            Gold += amount;
        }

        public void SpendGold(int amount)
        {
            if (Gold >= amount)
            {
                Gold -= amount;
            }
        }

        public void GainCrystals(int amount)
        {
            Crystals += amount;
        }

        public void SpendCrystals(int amount)
        {
            Crystals -= amount;
        }

        // Signals go here
        [Signal]
        public delegate void GoldChangedEventHandler(int newValue);

        [Signal]
        public delegate void CrystalsChangedEventHandler(int newValue);
    }
}