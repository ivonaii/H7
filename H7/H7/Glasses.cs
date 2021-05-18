using System;
using System.Collections.Generic;
using System.Text;

namespace H7
{
    public class Glasses
    {
        public virtual string GlassesType { get; set; }

        public virtual double Diopter
        {
            get
            {
                return 0;
            }
        }

        public virtual void ThePerfectGlasses()
        {
            Console.WriteLine("Create the perfect {0} glasses for you in our store!", GlassesType);
        }

        public Glasses(string glassestype)
        {
            GlassesType = glassestype;
        }
    }
}