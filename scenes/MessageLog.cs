using Godot;
using System;
using Godot.Collections;

namespace roguelikeidler.scenes
{
 
    public partial class MessageLog : VBoxContainer
    {
        [Export] public int MaxMessages = 10;
            
        private Array<Label> _messages;

        public MessageLog()
        {
            this._messages = [];
        }

        public void AddMessage(string message)
        {
            Label label = new Label();
            label.Text = $"{_messages.Count}: {message}";
            // Add the message
            _messages.Add(label);
            AddChild(label);
            MoveChild(label, 0);
        }
    }   
}
