using Godot;
using roguelikeidler.player;

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
