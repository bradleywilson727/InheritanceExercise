using System;
namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
        }

        public string ReptileColor { get; set; }

        public bool IsOmnivore { get; set; }

        public bool HasLegs { get; set; }

        public int EggsPerYear { get; set; }


    }
}
