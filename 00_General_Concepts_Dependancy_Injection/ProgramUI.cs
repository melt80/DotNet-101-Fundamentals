using System;

namespace _00_General_Concepts_Dependancy_Injection
{
    public class ProgramUI
    {
  
        private IConsole _console;

        public ProgramUI(IConsole console)
        {
            _console = console;
        }

        internal void Run()
        {
            _console.WriteLine("Hello");
            _console.ReadKey();
        }
    }
}