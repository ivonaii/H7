using System;
using System.Collections.Generic;

namespace H7
{
    class Optics
    {
        static void Main(string[] args)
        {
            var glasses = new List<Glasses>();
            glasses.Add(new Glasses("sun"));
            glasses.Add(new GlassesWithFilter("round", 1.25));
            glasses.Add(new Photosolar("photosolar round", 2.5));

            foreach(var glass in glasses)
            {
                glass.ThePerfectGlasses();
            }
        }
    }
}
