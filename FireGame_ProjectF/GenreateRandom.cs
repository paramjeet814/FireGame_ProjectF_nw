using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireGame_ProjectF
{
   public class GenreateRandom
    {
        //global array to pass the value 
        public int[] fire= new int[2];

        //create the instance of the random class to print 
        Random rd = new Random();

        //this method is used to return the value with store the random no to fire 
        public int array() {
            fire[0] = rd.Next(1, 4);
            fire[1] = rd.Next(1, 3);
            return fire[0];
        }

    }
}
