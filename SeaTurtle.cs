using System;

namespace Zoo
{
    class SeaTurtle : IWalking, ISwimming
    {
        public int MaximumDepth {get; } = 100;

        public void Run()
        {
            Console.WriteLine("Animal is now running");
        }

        public void Walk()
        {
            Console.WriteLine("Animal is now walking");
        }

        public void Swim()
        {
            Console.WriteLine("Aniaml is now swimming");
        }
    }
}