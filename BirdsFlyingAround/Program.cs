using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsFlyingAround
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird bird = new Swan();

            bird.Draw();
            bird.SetLocation(1, 1);
            if (bird is IFly)
            {
                ((IFly)bird).Fly(1);
            }
        }
    }
}
