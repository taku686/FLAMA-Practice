using UnityEngine;
using Zenject;

namespace Sample.Mediator.Sample1
{
    public class Participant
    {
        private Chatroom _chatroom;
        private string _name;

        public Participant(string name)
        {
            _name = name;
        }

        public string Name => _name;

        public Chatroom Chatroom
        {
            set => _chatroom = value;
            get => _chatroom;
        }

        public void Send(string to, string message)
        {
            _chatroom.Send(_name, to, message);
        }

        public virtual void Receive(string from, string message)
        {
            Debug.Log(from + " to " + Name + ": " + message + "'");
        }
    }
}