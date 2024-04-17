using System;

namespace Models
{
    public abstract class Animal
        {
            protected string Weight { get; set; }
            protected string Height { get; set; }

            public Animal(string Weight, string Height)
            {
                this.Weight = Weight;
                this.Height = Height;
            }
            public abstract void PrintInfo();
        }
        class Cat : Animal
        {
            private string Name { get; set; }
            public Cat(string Weight, string Height, string Name) : base(Weight, Height)
            {
                this.Name = Name;
            }
            public override void PrintInfo()
            {
                System.Console.WriteLine("Weight : {0}" + '\n' + "Height: {1}" + '\n' + "Name: {2}", this.Weight, this.Height, this.Name);
            }
        }
}