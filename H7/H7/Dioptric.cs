using System;
using System.Collections.Generic;
using System.Text;

namespace H7
{
    abstract class Dioptric : Glasses
    {
        public override string GlassesType { get; set; }

        public override double Diopter { get; }

        public abstract void DiopterSize();

        public virtual void Cleaning()
        {
            Console.WriteLine("Your glasses have just been cleaned! You owe us 30 cents.");
        }

        public Dioptric(string glassestype, double diopter) : base(glassestype)
        {
            Diopter = diopter;
        }
    }
}
