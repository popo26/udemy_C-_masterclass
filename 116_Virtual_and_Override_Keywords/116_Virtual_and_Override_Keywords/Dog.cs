using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace _116_Virtual_and_Override_Keywords
{
    class Dog : Animal
    {
        //bool property to check if the dog is Happy
        public bool IsHappy { get; set; }
        //simple constructor where we pass the name and age to our base constructor
        public Dog(string name, int age) : base(name, age)
        {
            //all dogs are happy
            IsHappy = true;
        }

        //simple override of the virtual method Eat
        public override void Eat()
        {
            //to call the eat method from our base Class we use the keyword "base"
            base.Eat();
        }

        //override of the virtual method MakeSound
        public override void MakeSound()
        {
            //since every animal will make a totally different sound
            //each animal will implement their own version of MakeSound
            Console.WriteLine("Wuuuf!");
        }

        //override of the virtual method Play
        public override void Play()
        {
            if (IsHappy)
            {
                base.Play();
            }

        }
    }
}
