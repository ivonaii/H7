using System;
using System.Collections.Generic;
using System.Text;

namespace H7
{
    class Photosolar : GlassesWithFilter
    {
        public override string GlassesType { get; set; }

        public override double Diopter { get; }

        public override void DiopterSize()
        {
            base.DiopterSize();
            Console.WriteLine("This photosolar glasses has plastic frames.");
        }

        public override void ThePerfectGlasses()
        {
            base.ThePerfectGlasses();
        }

        public Photosolar(string glassestype, double diopter) : base(glassestype, diopter)
        {

        }
    }
}

