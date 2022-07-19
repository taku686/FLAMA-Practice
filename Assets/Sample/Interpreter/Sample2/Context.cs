using UnityEngine;

namespace Sample.Interpreter.Sample2
{
    public class Context 
    {
        private string _input;
        private string _output;

        public Context(string input)
        {
            _input = input;
        }

        public string Input
        {
            get => _input;
            set => _input = value;
        }

        public string Output
        {
            get => _output;
            set => _output = value;
        }
    }
}