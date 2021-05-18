using System;
using System.Collections.Generic;
using System.Text;

namespace H7
{
    class GlassesWithFilter : Dioptric
    {
        public override string GlassesType  { get; set;}

        public override double Diopter { get; }

        public override void DiopterSize() 
        {
            Console.WriteLine("This {0} glasses are with {1} diopter.", GlassesType, Diopter) ;
        }

        public sealed override void Cleaning()
        {
            base.Cleaning();
        }

        public override void ThePerfectGlasses()
        {
            base.ThePerfectGlasses();
        }

        public GlassesWithFilter(string glassestype, double diopter) : base(glassestype, diopter)
        {
            
        }
    }
}
