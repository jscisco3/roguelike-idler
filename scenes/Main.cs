using Godot;
using roguelikeidler.player;
using EventTable = roguelikeidler.events.EventTable;

namespace roguelikeidler.scenes
{
    public partial class Main : Control
    {
        // Exported so it can be set in the explorer for now
        [Export] private Button _exploreButton;

        [Export] private Label _goldAmountLabel;
        [Export] private Label _crystalAmountLabel;

        // Exported so it can be set in the explorer for now
        [Export] private Player _player;

        [Export] private MessageLog _messageLog;

        // TODO: Handle this differently at some point.
        [Export] private EventTable _eventTable;

        public override void _Ready()
        {
            // Append this method to the Pressed actions?
            _exploreButton.Pressed += HandleButtonPressed;

            _player.GoldChanged += HandleGoldChanged;
            _player.CrystalsChanged += HandleCrystalsChanged;
        }

        private void HandleButtonPressed()
        {
            _player.GainGold(10);
            _player.GainCrystals(1);
            for (var i = 0; i < 10; i++)
            {
                var e = _eventTable.RollEvent();
                if (e == null) continue;
                _player.GainGold(e.GoldGainedOrLost);
                _player.GainCrystals(e.CrystalsGainedOrLost);
                _messageLog.AddMessage(e.Message);
            }
        }

        private void HandleGoldChanged(int newValue)
        {
            _goldAmountLabel.Text = newValue.ToString();
        }

        private void HandleCrystalsChanged(int newValue)
        {
            _crystalAmountLabel.Text = newValue.ToString();
        }
    }
}