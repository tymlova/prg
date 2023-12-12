using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPlayground
{
    public class Rectangle
    {
        public int width ;
        public int height;
        public int CalculateArea(int width, int height)
        {
            return width * height;
        }

        public void CalculateAspectRatio(int width, int height)
        {

           
           if (width < height)
            {
                for (int i = 2; i <= width; i++)
                {
                    if (width % i == 0 && height%i==0)
                    {
                        width = width / i;
                        height = height / i;
                    }
                    
                    
                }
                Console.WriteLine("poměr stran je " + width + " : " + height + ", obdélník je vysoký");
            }
           else if (height < width)
            {
                for (int i = 2; i <= height; i++)
                {
                    if (width % i == 0 && height % i == 0)
                    {
                        width = width / i;
                        height = height / i;
                    }
                    
                   
                    
                    
                }
                Console.WriteLine("poměr stran je " + width + " : " + height + ", obdélník je široký");
            }
           else 
            {
                Console.WriteLine("obdélník je čtverec, proto je v poměru 1 : 1");
            }
        }
    }
}
