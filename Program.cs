using System;
using System.Collections.Generic;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Pigeon p = new Pigeon();
            Seagull s = new Seagull();

            List<IFlying> birds = new List<IFlying>() {p, s};
        }
    }
}
