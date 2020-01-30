using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsFlyingAround
{
    class Swan : Bird, IFly
    {
        public override void Draw()
        {
            //Draws bird on screen
        }

        public void Fly(double altitude)
        {
           //Sets altitude of bird
        }

        public override void SetLocation(double longitude, double latitude)
        {
            //Sets  long + latitude of bird
        }
    }
}
